﻿using GreenBook.Client.Shared.Domain;
using GreenBook.Server.Models;
using GreenBook.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GreenBook.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Comment> Comments { get; }
        IGenericRepository<Post> Posts { get; }
        //IGenericRepository<ApplicationUser> ApplicationUser { get; }
        IGenericRepository<Like> Likes { get; }
        IGenericRepository<Location> Locations { get; }
        IGenericRepository<Tag> Tags { get; }
        IGenericRepository<Collection> Collections { get; }
    }
}