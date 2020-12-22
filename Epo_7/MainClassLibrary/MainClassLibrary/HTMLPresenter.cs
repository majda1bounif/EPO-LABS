using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public class HTMLPresenter : IPresenter
    {
        //The Header
        public string GetHeader()
        {
            return "\t" + "Название" + "\t" + "Цена" +
            "\t" + "Кол-во" + "Стоимость" + "\t" + "Скидка" +
            "\t" + "Сумма" + "\t" + "Бонус" + "\n";
        }

        //The Footer
        public string GetFooter(double totalAmount, int totalBonus)
        {
            return "Сумма счета составляет " + totalAmount.ToString() + "\nВы заработали " + totalBonus.ToString() + " бонусных баллов";
        }
        //String of Items
        public string GetItemString(double discount, int bonus, double thisAmount, Item item)
        {
            return "\t" + item.getGoods().getTitle() + "\t" + // or item
               "\t" + item.getPrice() + "\t" + item.getQuantity() +
               "\t" + (item.getQuantity() * item.getPrice()).ToString() +
               "\t" + discount.ToString() + "\t" + thisAmount.ToString() +
               "\t" + bonus.ToString() + "\n";
        }
    }
}