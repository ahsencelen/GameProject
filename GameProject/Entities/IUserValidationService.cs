using GameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
