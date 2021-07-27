from typing import List
from random import randrange

from visitor.visitor import Component, Visitor
from .observer import Subject, Observer

class CentralBank(Subject, Observer, Component):
    _observers: List[Observer] = []
    market_value: int = 0
    _previous_taxes: int = 0
    _desired_taxes = 0

    def __init__(self, inflation = None):
        self._inflation: float = inflation
        print(f"inflation is: {self._inflation}")

    def attach(self, observer: Observer):
        print("Bank: Attached an observer.")
        self._observers.append(observer)

    def detach(self, observer: Observer):
        self._observers.remove(observer)

    def notify(self):
        #print("Bank: Notifying observers")
        for observer in self._observers:
            observer.update(self)

    def calculate_inflation(self, epsilon = 100):
        prev_inflation = self._inflation
        self._previous_taxes = self.market_value + (self.market_value * self._inflation)
        if (self._desired_taxes == 0):
            self._desired_taxes = self.market_value + (self.market_value * self._inflation)
        while ((abs(prev_inflation - self._inflation)) <= 1.5):
            #print(f"{(abs(prev_inflation - self._inflation) <= 2.0)}")
            taxes_now = self.market_value + (self.market_value * self._inflation)
            delta = abs(taxes_now - self._desired_taxes)
            if delta >= epsilon:
                if taxes_now >= self._desired_taxes:
                    self._inflation -= 0.1
                if taxes_now < self._desired_taxes:
                    self._inflation += 0.1
            else:
                break
        #print(self.market_value)
        self.market_value = 0
        self.notify()
        

    def update(self, subject: Subject) -> None:
        self.market_value += subject._bought_value
        #print(self.market_value)

    def accept(self, visitor: Visitor):
        visitor.visit_bank(self)

    def _get_inflation(self):
        return self._inflation
    
    def _get_market_value(self):
        return self._previous_taxes

    def _get_desired_market_value(self):
        return self._desired_taxes