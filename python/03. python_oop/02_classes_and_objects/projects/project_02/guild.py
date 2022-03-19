from project.player import Player

class Guild:
    def __init__(self, name):
        self.name = name
        self.players = []

    def assign_player(self, player: Player):
        if not player.guild == self.name and not player.guild == "Unaffiliated":
            return f"Player {player.name} is already in the guild."

        current_player = [p for p in self.players if p == player]
        if current_player:
            current_player = current_player[0]
            return f"Player {player.name} is already in the guild."

        self.players.append(player)
        player.guild = self.name
        return f"Welcome player {player.name} to the guild {self.name}"

    def kick_player(self, player_name: str):
        current_player = [p for p in self.players if p.name == player_name]
        if not current_player:
            return f"Player {player_name} is not in the guild."

        current_player = current_player[0]
        self.players.remove(current_player)
        current_player.guild = "Unaffiliated"
        return f"Player {player_name} has been removed from the guild."

    def guild_info(self):
        res = f"Guild: {self.name}\n"
        for p in self.players:
            res += p.player_info()
        return res


player = Player("George", 50, 100)
print(player.add_skill("Shield Break", 20))
print(player.player_info())
guild = Guild("UGT")
print(guild.assign_player(player))
print(guild.guild_info())
