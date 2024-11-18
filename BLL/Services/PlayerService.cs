using BLL.DAL;
using BLL.Models;
using BLL.Services.Bases;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    

    public class PlayerService : ServiceBase, IService<Player, PlayerModel>
    {

        public PlayerService(Db db) : base(db)
        {
            
        }

        public ServiceBase Create(Player record)
        {
            if (_db.Players.Any(p => p.Name.ToLower() == record.Name.ToLower().Trim() && p.Surname.ToLower() == record.Surname.ToLower().Trim() && p.IsFemale == record.IsFemale && p.Birthdate == record.Birthdate))
                return Error("Player with the same name exists!");
            record.Name = record.Name?.Trim();
            _db.Players.Add(record);
            _db.SaveChanges();
            return Success("Player created successfully. ");
        }

        public ServiceBase Delete(int id)
        {
            var entity = _db.Players.SingleOrDefault(p => p.Id == id);
            if (entity is null)
                return Error("Player cannot be found! ");
            _db.Players.Remove(entity);
            _db.SaveChanges();
            return Success("Team deleted successfully. ");
        }

        public IQueryable<PlayerModel> Query()
        {
           return _db.Players.Include(p => p.Team).OrderByDescending(p => p.Name).Select(p => new PlayerModel() { Record = p });
        }

        public ServiceBase Update(Player record)
        {
            if (_db.Players.Any(p => p.Id != record.Id && p.Name.ToLower() == record.Name.ToLower().Trim() && 
            p.Surname.ToLower() == record.Surname.ToLower().Trim() && p.IsFemale == record.IsFemale && p.Birthdate == record.Birthdate))
                return Error("Player with the same name exists!");
            record.Name = record.Name?.Trim();
            _db.Players.Update(record);
            _db.SaveChanges();
            return Success("Player updated successfully. ");
        }
    }
}
