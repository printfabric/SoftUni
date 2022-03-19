text = input()
unic_elements = set()
dict = {}

for i in range(len(text)):
    unic_elements.add(text[i])

unic_elements = list(unic_elements)

for i in range(len(unic_elements)):
    dict[unic_elements[i]] = text.count(unic_elements[i])


dictionary_items = dict.items()

sorted_items = sorted(dictionary_items)

for k, v in sorted_items:
    print(f"{k}: {v} time/s")
