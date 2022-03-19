class Band:
    def __init__(self, name):
        self.name = name
        self.albums = []

    def add_album(self, album):
        if album in self.albums:
            return f"Band {self.name} already " \
                   f"has {album.name} in their library."
        self.albums.append(album)
        return f"Band {self.name} has added " \
               f"their newest album {album.name}."

    def remove_album(self, album_name):
        filtered_albums = [a for a in self.albums if a.name == album_name]

        if not filtered_albums:
            return f"Album {album_name} is not found."

        filtered_albums = filtered_albums[0]
        if filtered_albums.published:
            return "Album has been published. It cannot be removed."
        self.albums.remove(filtered_albums)
        return f"Album {filtered_albums.name} has been removed."

    def details(self):
        res = f"Band {self.name}\n"
        for album in self.albums:
            res += album.details()

        return res


