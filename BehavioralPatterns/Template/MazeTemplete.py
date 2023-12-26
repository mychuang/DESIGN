from abc import ABC, abstractmethod
from Adventurer import Adventurer

class MazeTemplate(ABC):
    def __init__(self):
        self.difficulty = 0
        self.adventurer = None
        self.is_double_maze = False  # hook: 決定是否有隱藏迷宮

    def adventur(self, adventurer: Adventurer):
        self.adventurer = adventurer

        # 確認冒險者等級
        if not self.check_level(self.adventurer.level):
            print("Level is not enough")
        else:
            print(type(self).__name__ + " rise up the difficulty")

            # 產生迷宮
            self.create_maze()

            # 闖迷宮
            self.start()

            # 掛勾: 隱藏迷宮
            if self.is_double_maze:
                self.hidden_maze()

            # 結束冒險
            self.show_result()

        return self.adventurer

    def check_level(self, level):
        return level >= self.difficulty

    # 迷宮內容
    @abstractmethod
    def create_maze(self):
        pass

    # 進入迷宮
    @abstractmethod
    def start(self):
        pass

    # 掛勾: 隱藏迷宮
    def hidden_maze(self):
        print("Go to hidden maze")

    # 冒險結束
    def show_result(self):
        # 等級增加
        self.adventurer.level += 50 * self.difficulty

        print(type(self).__name__ + " Complete Maze difficulty: " + str(self.difficulty))

        return self.adventurer

# 簡單迷宮
class EasyMaze(MazeTemplate):
    def __init__(self):
        super().__init__()
        self.difficulty = 1

    def create_maze(self):
        print("!!! Generated Easy Maze !!!")

    def start(self):
        print("-- start Easy Maze --")

# 困難迷宮
class DifficultMaze(MazeTemplate):
    def __init__(self):
        super().__init__()
        self.is_double_maze = True  # 困難模式有隱藏關卡
        self.difficulty = 50  # 等級50才能進入迷宮

    def create_maze(self):
        print("### Generated Difficult Maze ###")

    def start(self):
        print("-*- start Difficult Maze -*-")