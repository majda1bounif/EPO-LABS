using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_5
{
    public class BillGenerator
    {
        private List<Item> _items;
        private Customer _customer;
        private IPresenter p;
        public BillGenerator(Customer customer, IPresenter presenter)
        {
            this._customer = customer;
            this._items = new List<Item>();
            this.p = presenter;
        }
        public void addGoods(Item arg)
        {
            _items.Add(arg);
        }
        public string GenerateBill()
        {
            double totalAmount = 0;
            int totalBonus = 0;
            String Print = "Счет для " + _customer.getName() + "\n";
            Print += p.GetHeader();

            foreach (Item item in _items)
            {
                int bonus = item.GetBonus();
                double discount = item.GetDiscount();
                double totalPrice = item.getQuantity() * item.getPrice();
                double PriceWithDiscount = totalPrice - discount;
                double usedBonus = UseBonus(item, PriceWithDiscount);
                double thisAmount = PriceWithDiscount - usedBonus;
                totalAmount = +thisAmount;
                totalBonus = +totalBonus + bonus;

                Print += p.GetItemString(discount, bonus, thisAmount, item);
            }

            Print += p.GetFooter(totalAmount, totalBonus); //display the footer
            _customer.receiveBonus(totalBonus);
            return Print;
        }

        public void Presenter(IPresenter presenter)
        {
            p = presenter;
        }

        //Formula Of Total Cost
        private double Total_Price(Item item)
        {
            return item.getQuantity() * item.getPrice();
        }

        //using Bonuses 
        private double UseBonus(Item item, double PriceWithDiscount)
        {
            double bonus = 0.0;
            if ((item.getGoods().GetType() == typeof(RegularItem)) && item.getQuantity() > 5)
                bonus = _customer.useBonus((int)PriceWithDiscount);
            else if ((item.getGoods().GetType() == typeof(SpecialItem)) && item.getQuantity() > 1)
                bonus = _customer.useBonus((int)PriceWithDiscount);
            return bonus;
        }
    }
}

