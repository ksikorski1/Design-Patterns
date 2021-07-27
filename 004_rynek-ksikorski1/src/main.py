from observer.bank import CentralBank
from observer.seller import Seller
from observer.buyer import Buyer
from observer.items import *
from visitor.visitor import ConcreteVisitor

import matplotlib.pyplot as plt

def main():
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

    visitor = ConcreteVisitor()

    inflacja = []
    market = []

    print("\n\n\n\n")

    for i in range(0, 20):
        seller.sell_to_subscribers()

        buyer.accept(visitor)

        seller.accept(visitor)
        bank.accept(visitor)

        #print(buyer.get_money())

        market.append(bank._get_market_value())
        inflacja.append(bank._get_inflation())
    
    print(f"oczekiwane {bank._get_desired_market_value()}")

    print(inflacja[0:10])
    print("\n market\n")
    print(market[0:10])

    plt.plot(market)
    plt.show()

    #plt.plot(inflacja)
    #plt.show()

if __name__ == "__main__":
    main()