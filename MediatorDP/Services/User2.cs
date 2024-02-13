﻿using System;
using MediatorDP.MediatorConector;

namespace MediatorDP.Services
{
    public class User2 : IChatService
    {
        Mediator _mediator;

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("(User2) Message Receive:{0}", message);
        }

        public override string SendMessage(string message)
        {
            _mediator.NotifyChange(message, this);
            return message;
        }


    }


}
