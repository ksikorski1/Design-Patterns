import threading
# 1. Odporność na współbieżne wykorzystanie kodu z jednoczesnym zachowaniem maksymalnej wydajności
# 4. W programie wielowątkowym, konstrukcja zapewniająca jeden singleton na wątek

class Singleton(type):
    _instances = {}
    _lock: threading.Lock = threading.Lock()
    def __call__(cls, *args, **kwargs):
        with cls._lock:
            if cls not in cls._instances:
                cls._instances[cls] = super(Singleton, cls).__call__(*args, **kwargs)
        return cls._instances[cls]

class SingletonClass(metaclass=Singleton):
    pass

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

class SingletonThreadLocal(type):
    _local = threading.local()
    def __call__(cls, *args, **kwargs):
        try:
            return getattr(SingletonThreadLocal._local, cls.__name__)
        except AttributeError:
            instance = super(SingletonThreadLocal, cls).__call__()
            setattr(SingletonThreadLocal._local, cls.__name__, instance)
            return instance

class SingletonClassThreadLocal(metaclass=SingletonThreadLocal):
    pass