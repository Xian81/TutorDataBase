using System.Collections.Generic;
using System.Linq;
using Tutorsdatabase.Data;
using Tutorsdatabase.Data.IDAO;
namespace Tutorsdatabase.Data.DAO
{
    public class TutorDAO : ITutorDao
    {

        private TutorsdatabaseEntities _context;

        public TutorDAO()
        {
            _context = new TutorsdatabaseEntities();
        }

        public User GetTutor(int id)
        {
          
           var _user = from user
                     in _context.Users
                     where user.Id == id
                     select user;
            return _user.FirstOrDefault();

        }

        // add tutor
        public void addTutor(User user)
        {
            user.Password = "123qwe";
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void deleteTutor(User user)
        {
            
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void editTutor(User user)
        {
            user.Password = "123qwe";
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
         
            _context.SaveChanges();
        }

        

        public List<User>GetTutors()
        {
            return _context.Users.ToList();
        }
    }
}
