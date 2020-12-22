using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_6
{
    public class BillGenerator
    {
        private List<Item> _items;
        private Customer _customer;
        private IPresenter p;
        public BillGenerator(Customer customer, IPresenter presenter)
        {
            _customer = customer;
            _items = new List<Item>();
            p = presenter;
        }
        public void addGoods(Item arg)
        {
            _items.Add(arg);
        }
        public int GetUsedBonus(Item each)
        {
            double Sum = each.GetSum() - each.GetDiscount();
            if (each.PossibilityOfBonus()) return _customer.useBonus((int)(Sum));
            return 0;
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
                //double totalPrice = item.getQuantity() * item.getPrice();
                //double PriceWithDiscount = totalPrice - discount;
                double usedBonus = GetUsedBonus(item);
                double thisAmount = item.GetSum() - discount - usedBonus;
                totalAmount += thisAmount;
                totalBonus += bonus;



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

    }
}