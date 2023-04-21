using System;
using Microsoft.AspNetCore.Mvc;
using StadiumApi.Models;

namespace StadiumApi.Services.VisitorService
{
    public class VisitorService : IVisitorService
    {
        #region ctor

        public VisitorService()
        {
        }

        #endregion

        public async Task<List<Visitor>> GetVisitors()
        {
            throw new NotImplementedException();
        }

        public async Task<string> AddVisitor(Visitor visitor)
        {
            throw new NotImplementedException();
        }

        public async Task<Visitor> UpdateVisitor(int id, Visitor visitor)
        {
            throw new NotImplementedException();
        }

        public async Task<string> DeleteVisitor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Visitor>> SearchVisitor(string name = null, int? fromAge = null, int? toAge = null)
        {
            throw new NotImplementedException();
        }
    }
}