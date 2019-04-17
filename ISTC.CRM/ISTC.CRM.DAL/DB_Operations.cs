using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISTC.CRM.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ISTC.CRM.DAL
{
    public class DB_Operations
    {
        public static void Create(User user)
        {
            using (Context db = new Context())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }


        public static User Read(int Id)
        {
            using (Context db = new Context())
            {
                return db.User.ToList()[Id-1];
            }
        }

        public static void Update(User user)
        {
            using (Context db = new Context())
            {
                db.User.Update(user);
                db.SaveChanges();
            }
        }

        public static void Delete(User user)
        {
            using (Context db = new Context())
            {
                db.User.Remove(user);
                db.SaveChanges();
            }
        }



    }
}
