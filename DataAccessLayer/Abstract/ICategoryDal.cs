﻿using DataAccessLayer.Abstract.Shared;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
    }
}
