﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManager.Application.Dtos
{
    public class CustomerResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
