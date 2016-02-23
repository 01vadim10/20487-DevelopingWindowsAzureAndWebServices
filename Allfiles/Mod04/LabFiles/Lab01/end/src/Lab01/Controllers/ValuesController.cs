﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Lab01.Model;
using Microsoft.Data.Entity;

namespace Lab01.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        BlogSystemContext _context;
        public ValuesController(BlogSystemContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            var query = from b in _context.Blogs.Include(b => b.Posts)
                        orderby b.Name
                        select b;
            return query.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            var query = from b in _context.Blogs
                        where b.Id == id
                        select b;

            return query.Single();
        }
    }
}
