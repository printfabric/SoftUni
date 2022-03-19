class Album:
    def __init__(self, name, songs=None):
        self.name = name
        if songs is None:
            songs = []
        if not isinstance(songs, list):
            self.songs = []
        else:
            self.songs = songs
        self.published = False

    def add_song(self, song):
        if song in self.songs:
            return f"Song is already in the album."
        elif self.published:
            return f"Cannot add songs. Album is published."
        elif song.single:
            return f"Cannot add {song.name}. It's a single"

        self.songs.append(song)
        return f"Song {song.name} has been added " \
               f"to the album {self.name}."

    def remove_song(self, song_name):
        if self.published:
            return "Cannot remove songs. Album is published."

        filtered_songs = [s for s in self.songs if s.name == song_name]
        if not filtered_songs:
            return f"Song is not in the album."

        self.songs.remove(filtered_songs[0])
        return f"Removed song {song_name} from album {self.name}."

    def publish(self):
        if self.published:
            return f"Album {self.name} is already published."
        self.published = True
        return f"Album {self.name} has been published."

    def details(self):
        res = f"Album {self.name}\n"
        for s in self.songs:
            res += f"== {s.get_info()}\n"
        return res


