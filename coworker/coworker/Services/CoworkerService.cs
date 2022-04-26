using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using coworker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace coworker.Services
{
    public class CoworkerService
    {
        private readonly coworkerContext context;
        public CoworkerService(coworkerContext context)
        {
            this.context = context;
            context.ChangeTracker.LazyLoadingEnabled = false;
        }

        public int GetAllWorker()
        {
            return context.Coworkers.Count();
        }
        public Coworker GetStudentByEmail(string email)
        {
            return context.Coworkers.Include(s => s.Phones).Include(s => s.Notebooks).First(s => s.Email == email);
        }

        //public IEnumerable<Coworker> GetOrderByCostumer(int id, DateTime datetime)
        //{

        //    return context.Coworkers.Where(x => x.Id == ).Select(o => o.Product);

        //    //return context.Costumers.Where(x => x.Id== id).SelectMany(o => o.Orders).SelectMany(a=>a.OrderProducts).Select(op=>op.Product).ToHashSet();

        //    //Console.WriteLine(httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "User Hash")?.Value);
        //    //return context.Coworkers.Where(p => p.Id.(op => op.Order.CostumerId == id && op.Order.PaidAt >= datetime));

        //}
    }
}
