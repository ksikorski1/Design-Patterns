from observer.buyer import Buyer
from observer.bank import CentralBank
from observer.seller import Seller
from observer.items import *
from visitor.visitor import TestVisitor


if __name__ == "__main__":
    bank = CentralBank(1)
    seller = Seller(offer)
    buyer = Buyer()

    visitor = TestVisitor()

    buyer.accept(visitor)
    seller.accept(visitor)
    bank.accept(visitor)