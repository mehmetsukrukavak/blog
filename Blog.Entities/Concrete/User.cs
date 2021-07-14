﻿using System;
using System.Collections.Generic;
using Blog.Shared.Entities.Abstract;

namespace Blog.Entities.Concrete
{
    public class User:EntityBase,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }

        public string UserName { get; set; }
        public Role Role { get; set; }
        public ICollection<Article> Articles { get; set; }

        public string Picture { get; set; }
        public string Description { get; set; }

    }
}
