using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Bank
    {
        User[] userarr = new User[10];
        int index = 0;
        public Bank(User user)
        {
            userarr[index++] = user;
        }

    }
}
