using System;
using Microsoft.AspNetCore.Mvc;
using StadiumApi.Models;

namespace StadiumApi.Services.VisitorService
{
	public interface IVisitorService
	{
		Task<List<Visitor>> GetVisitors();

        Task<string> AddVisitor(Visitor visitor);

        Task<string> DeleteVisitor(int id);

        Task<Visitor> UpdateVisitor(int id, Visitor visitor);

        Task<List<Visitor>> SearchVisitor(string name = null, int? fromAge = null, int? toAge = null);
    }
}