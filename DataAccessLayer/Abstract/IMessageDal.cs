﻿using DataAccessLayer.Abstract.Shared;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal : IRepository<Message>
    {
    }
}
