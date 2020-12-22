﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public interface IPresenter
    {
        string GetHeader();
        string GetFooter(double totalAmount, int totalBonus);
        string GetItemString(double discount, int bonus, double thisAmount, Item item);
    }
}
