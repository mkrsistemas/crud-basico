﻿using System;
using System.Collections.Generic;
using Domain.Entities;
using FluentValidation;

namespace Domain.Interfaces
{
    public interface IService <T> where T: BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
