class Zoo:
    def __init__(self, name, budget, animal_capacity, workers_capacity):
        self.__animal_capacity = animal_capacity
        self.__workers_capacity = workers_capacity
        self.__budget = budget
        self.name = name
        self.animals = []
        self.workers = []

    def add_animal(self, animal, price):
        if self.__budget >= price and len(self.animals) < self.__animal_capacity:
            self.animals.append(animal)
            self.__budget -= price
            return  f"{animal.name} the {animal.__class__.__name__} added to the zoo"
        elif len(self.animals) < self.__animal_capacity and self.__budget < price:
            return f"Not enough budget"
        return "Not enough space for animal"

    def hire_worker(self, worker):
        if len(self.workers) < self.__workers_capacity:
            self.workers.append(worker)
            return f"{worker.name} the {worker.__class__.__name__} hired successfully"
        return "Not enough space for worker"

    def fire_worker(self, worker_name):
        filter_worker_name = [x for x in self.workers if x.name == worker_name]
        if filter_worker_name:
            self.workers.remove(filter_worker_name[0])
            return f"{worker_name} fired successfully"
        return f"There is no {worker_name} in the zoo"

    def pay_workers(self):
        result = 0

        for s in range(len(self.workers)):
            result += self.workers[s].salary

        if result <= self.__budget:
            self.__budget -= result
            return f"You payed your workers. They are happy. Budget left: {self.__budget}"
        return "You have no budget to pay your workers. They are unhappy"

    def tend_animals(self):
        result = 0

        for i in range(len(self.animals)):
            result += self.animals[i].money_for_care

        if result <= self.__budget:
            self.__budget -= result
            return f"You tended all the animals. They are happy. Budget left: {self.__budget}"
        return "You have no budget to tend the animals. They are unhappy."

    def profit(self, amount):
        self.__budget += amount

    def animals_status(self):
        an_result = f"You have {len(self.animals)} animals\n"
        lions = [x for x in self.animals if x.__class__.__name__ == "Lion"]
        an_result += f"----- {len(lions)} Lions:\n"
        for i in range(len(lions)):
            an_result += f"Name: {lions[i].name}, Age: {lions[i].age}, Gender: {lions[i].gender}\n"

        tigers = [x for x in self.animals if x.__class__.__name__ == "Tiger"]
        an_result += f"----- {len(tigers)} Tigers:\n"
        for i in range(len(tigers)):
            an_result += f"Name: {tigers[i].name}, Age: {tigers[i].age}, Gender: {tigers[i].gender}\n"

        cheetahs = [x for x in self.animals if x.__class__.__name__ == "Cheetah"]
        an_result += f"----- {len(cheetahs)} Cheetahs:\n"
        for i in range(len(cheetahs)):
            if i == len(cheetahs) - 1:
                an_result += f"Name: {cheetahs[i].name}, Age: {cheetahs[i].age}, Gender: {cheetahs[i].gender}"
            else:
                an_result += f"Name: {cheetahs[i].name}, Age: {cheetahs[i].age}, Gender: {cheetahs[i].gender}\n"

        return an_result

    def workers_status(self):
        result = ""
        result += f"You have {len(self.workers)} workers\n"
        keepers = [x for x in self.workers if x.__class__.__name__ == "Keeper"]
        result += f"----- {len(keepers)} Keepers:\n"
        for i in range(len(keepers)):
            result += f"Name: {keepers[i].name}, Age: {keepers[i].age}, Salary: {keepers[i].salary}\n"

        caretakers = [x for x in self.workers if x.__class__.__name__ == "Caretaker"]
        result += f"----- {len(caretakers)} Caretakers:\n"
        for i in range(len(caretakers)):
            result += f"Name: {caretakers[i].name}, Age: {caretakers[i].age}, Salary: {caretakers[i].salary}\n"

        vets = [x for x in self.workers if x.__class__.__name__ == "Vet"]
        result += f"----- {len(vets)} Vets:\n"
        for i in range(len(vets)):
            if i == len(vets) - 1:
                result += f"Name: {vets[i].name}, Age: {vets[i].age}, Salary: {vets[i].salary}"
            else:
                result += f"Name: {vets[i].name}, Age: {vets[i].age}, Salary: {vets[i].salary}\n"

        return result
