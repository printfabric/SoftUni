function solve(input) {
  class Song {
    constructor(typeList, name, time) {
      this.typeList = typeList;
      this.name = name;
      this.time = time;
    }
  }

  let n = input.shift();
  let songs = [];

  for (let i = 0; i < n; i++) {
    let splittedInput = input.shift().split('_');
    let [typeList, name, time] = splittedInput;
    let song = new Song(typeList, name, time);

    songs.push(song);
  }

  let wantedTypeList = input.shift();

  for (const song of songs) {
    if (song.typeList == wantedTypeList || wantedTypeList == 'all') {
      console.log(song.name);
    }
  }
}

solve([2, 'like_Replay_3:15', 'ban_Photoshop_3:48', 'all']);
