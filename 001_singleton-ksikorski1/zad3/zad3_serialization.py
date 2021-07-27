import pickle
import threading

class SingletonOptimized(type):
    _instances = {}
    _lock: threading.Lock = threading.Lock()
    def __call__(cls, *args, **kwargs):
        if cls not in cls._instances:    
            with cls._lock:
                if cls not in cls._instances:
                    cls._instances[cls] = super(SingletonOptimized, cls).__call__(*args, **kwargs)
        return cls._instances[cls]

class SingletonClassOptimized(metaclass=SingletonOptimized):
    pass


class Singleton():
    instance = None
    _lock: threading.Lock = threading.Lock()
    def __new__(cls, *args):
        if not cls.instance:
            with cls._lock:
                if not cls.instance:
                    cls.instance = super(Singleton, cls).__new__(cls, *args)
        return cls.instance