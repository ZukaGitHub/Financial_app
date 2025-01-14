﻿using Domain.SharedModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Client.DeleteClient
{
    public class DeleteClientCommand:IRequest<DeleteClientResponseModel>
    {
        public int Id { get; set; }
    }
}
