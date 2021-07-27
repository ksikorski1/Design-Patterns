from observer.bank import CentralBank
from observer.seller import Seller
from observer.buyer import Buyer
from observer.items import *


if __name__ == "__main__":
    bank = CentralBank(1)
    seller = Seller(offer)
    buyer = Buyer()

    #obserwujacy banku
    bank.attach(seller)
    bank.attach(buyer)

    #obserwujacy sprzedawcow
    seller.attach(bank)
    seller.attach(buyer)

    #obserwujacy kupcow
    buyer.attach(bank)
    #buyer.attach(seller)


    for i in range(0, 5):
        seller.sell_to_subscribers()

        #bank.calculate_inflation()