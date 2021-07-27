from typing import List
from random import randrange

from visitor.visitor import Visitor, Component
from .observer import Subject, Observer
from .bank import CentralBank

class Seller(Subject, Observer, Component):
    _sold_value: int = 0
    _observers: List[Observer] = []
    inflation = 1

    def __init__(self, offer):
        self.offer = offer
        for key in self.offer:
            self.offer[key]['price'] = self.inflation * self.offer[key]['creationPrice'] * self.offer[key]['profit']
            #(self.offer[key]['price'])
            self.offer[key]['quantity'] = randrange(5, 10)
            #print(self.offer[key]['quantity'])

    def attach(self, observer: Observer):
        print("Seller: Attached an observer.")
        self._observers.append(observer)

    def detach(self, observer: Observer):
        self._observers.remove(observer)

    def notify(self):
        print("Seller: Notifying observers...")
        for observer in self._observers:
            observer.update(self)

    def update(self, subject: Subject):
        if (not isinstance(subject, CentralBank)):
            #print("reacting!")
            if (subject.willingness >= 1):
                print("They bought my product!")
        if isinstance(subject, CentralBank):
            #print("Inflation changed")
            self.inflation = subject._inflation
            #print(self.inflation)

    def sell_to_subscribers(self):
        #print(f"obserwatorow: {len(self._observers)}")
        for observer in self._observers:
            if (not isinstance(observer, CentralBank)):
                observer.buy(self)

    def accept(self, visitor: Visitor):
        visitor.visit_seller(self)

    def change_prices(self):
        for key in self.offer:
            self.offer[key]['price'] = self.offer[key]['creationPrice'] * self.offer[key]['profit'] + self.offer[key]['creationPrice'] * self.inflation
            #(self.offer[key]['price'])
            self.offer[key]['quantity'] = randrange(5, 10)
            #print(self.offer[key]['quantity'])
                