using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace boxwear
{
    public class CreditCardUtility
    {
        protected static CreditCardUtility _instance = new CreditCardUtility();
        protected CreditCard _card;
        public CreditCard Card
        {
            get
            {
                if (this._card == null)
                    this._card = new CreditCard();
                return this._card;
            }
            set
            {
                this._card = value;
            }
        }
        public static CreditCardUtility Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CreditCardUtility();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        private CreditCardUtility()
        {
        }

        static CreditCardUtility()
        {
        }

        public static String GetTypeName(String cardNumber)
        {
            return Instance.Card.GetCardType(cardNumber);
        }
    }
}