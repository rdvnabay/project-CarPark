using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
   public class Result
    {
        public string Message { get; set; }
        public bool Success { get; set; }

        public class GetOneResult<TEntity>:Result
            where TEntity:class,new()
        {
            public TEntity Entity { get; set; }
        }

        public class GetManyResult<TEntity> : Result
           where TEntity : class, new()
        {
            public IEnumerable<TEntity> Entity { get; set; }
        }
    }
}
