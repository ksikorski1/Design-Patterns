import random
from typing import List

from visitor.visitor import Visitor, Component
from .observer import Subject, Observer
from .bank import CentralBank

class Buyer(Subject, Observer, Component):
    _observers: List[Observer] = []
    
    def __init__(self, money = 900):
        self.money = money
        self.mood = random.uniform(-1.0, 1.0)
        self._bought_value: int = 0

    def attach(self, observer: Observer):
        print("Buyer: Attached an observer.")
        self._observers.append(observer)

    def detach(self, observer: Observer):
        self._observers.remove(observer)

    def notify(self):
        #print("Buyer: Notifying observers...")
        for observer in self._observers:
            observer.update(self)

    def update(self, subject: Subject):
        pass

    def buy(self, subject: Subject):
        #print(f"{self.__class__.__name__}")
        if (not isinstance(subject, CentralBank)):
            for item in subject.offer:
                self.mood = random.uniform(-1.0, 1.0)
                if subject.offer[item]['quantity'] > 0:
                    if subject.offer[item]['price'] > self.money:
                        pass
                    if subject.offer[item]['price'] <= self.money:
                        self.willingness = (self.money / subject.offer[item]['price']) + self.mood
                        #print(f"willingness: {self.willingness}")
                        if (self.willingness >= 1):
                            quantity = self._calculate_quantity(subject.offer[item])
                            self.money -= subject.offer[item]['price'] * quantity
                            self._bought_value += subject.offer[item]['price'] * quantity
                            #print(f"wartosc kupionych przed: {self._bought_value}")
                            subject.offer[item]['quantity'] -= quantity
        self.notify()
        self._bought_value = 0
    
    def _calculate_quantity(self, item):
        max_quantity = random.randrange(1, 10)
        quantity = int(self.willingness)
        if (max_quantity < int(self.willingness)):
            quantity = max_quantity
        #print(f"Buying max amount: {quantity}")
        price = item['price'] * int(self.willingness)
        too_expensive = price > self.money
        while (too_expensive):
            price = item['price'] * quantity
            if (price <= self.money):
                too_expensive = False
                break
            quantity -= 1
        return quantity

    def accept(self, visitor: Visitor):
        visitor.visit_buyer(self)

    def give_money(self):
        self.money = random.randint(500, 1500)
        self._bought_value = 0

    def get_money(self):
        return self.money