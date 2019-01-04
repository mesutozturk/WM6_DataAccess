using Otel.Models.Entities;
using System;
using Otel.Models.ViewModels;

namespace Otel.BLL.Repository
{
    public class ReservationRepo : RepositoryBase<Reservation, Guid>
    {
        public Guid MakeReservation(MakeReservationViewModel model)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var reservation = new Reservation
                    {
                        ReservationDate = model.ReservationDate,
                        CheckOutDate = model.CheckOutDate,
                        RoomId = model.RoomId
                    };
                    db.Reservations.Add(reservation);
                    db.SaveChanges();

                    foreach (var registerViewModel in model.RegisterViewModels)
                    {
                        db.ReservationDetails.Add(new ReservationDetail()
                        {
                            FirstName = registerViewModel.Firstname,
                            LastName = registerViewModel.Surname,
                            ReservationId = reservation.Id,
                            TelephoneNumber = registerViewModel.Number
                        });
                        db.SaveChanges();
                    }
                    
                    var room = db.Rooms.Find(model.RoomId);
                    room.IsEmpty = false;
                    db.SaveChanges();

                    tran.Commit();
                    return reservation.Id;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
