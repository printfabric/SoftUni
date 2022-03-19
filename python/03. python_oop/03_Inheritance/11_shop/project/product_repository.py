from project.product import Product


class ProductRepository:
    def __init__(self):
        self.products = []

    def add(self, product):
        self.products.append(product)

    def find(self, product_name):
        filtered_products = \
            [x for x in self.products if x.name == product_name]
        if filtered_products:
            return filtered_products[0]

    def remove(self, product_name):
        filtered_products = \
            [x for x in self.products if x.name == product_name]
        if filtered_products:
            self.products.remove(filtered_products[0])

    def __str__(self):
        result = ""

        for product in self.products:
            result += f"{product.name}: {product.quantity}\n"

        return result
