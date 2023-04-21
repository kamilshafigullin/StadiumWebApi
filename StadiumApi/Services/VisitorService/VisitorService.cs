using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StadiumApi.Data;
using StadiumApi.Models;

namespace StadiumApi.Services.VisitorService
{
    public class VisitorService : IVisitorService
    {
        #region Fields

        DataContext context;

        #endregion

        #region ctor

        public VisitorService(DataContext context)
        {
            this.context = context;
        }

        #endregion

        public async Task<List<Visitor>> GetVisitors()
        {
            var result = await context.Visitors.ToListAsync();

            return result;
        }

        public async Task<string> AddVisitor(Visitor visitor)
        {
            context.Visitors.Add(visitor);
            await context.SaveChangesAsync();

            return "Успешно";
        }

        public async Task<Visitor> UpdateVisitor(int id, Visitor visitor)
        {
            var entity = await context.Visitors.FindAsync(id);
            if (entity == null)
                return null;

            entity.Name = visitor.Name;
            entity.Address = visitor.Address;
            entity.Age = visitor.Age;
            entity.BirthDate = visitor.BirthDate;
            entity.Email = visitor.Email;
            entity.PhoneNumber = visitor.PhoneNumber;
            entity.Sex = visitor.Sex;
            entity.Surname = visitor.Surname;

            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<string> DeleteVisitor(int id)
        {
            var entity = await context.Visitors.FindAsync(id);
            if (entity == null)
                return null;

            context.Visitors.Remove(entity);
            await context.SaveChangesAsync();
            return "Успешно";
        }

        public async Task<List<Visitor>> SearchVisitor(string name = null, int? fromAge = null, int? toAge = null)
        {
            var result = await context.Visitors.ToListAsync();
            if (result == null)
                return null;

            List<Visitor> visitors = null;
            if (name != null)
                visitors = result.Where(x => x.Name == name).ToList();
            if (fromAge.HasValue && toAge.HasValue)
                visitors = (visitors ?? result).Where(x => x.Age >= fromAge && x.Age <= toAge).ToList();

            return visitors;
        }
    }
}