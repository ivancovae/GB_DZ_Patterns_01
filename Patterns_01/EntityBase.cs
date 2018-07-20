﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_01
{
    public abstract class EntityBase
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }

        public EntityBase(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }
    }
}
