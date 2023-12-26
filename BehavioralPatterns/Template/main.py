from Adventurer import Sabar, GundamJustice
from MazeTemplete import EasyMaze, DifficultMaze

sabar = Sabar()  # 等級10的劍士
justice = GundamJustice()  # 等級100的正義鋼彈

easy_maze = EasyMaze()  # 簡單迷宮
hard_maze = DifficultMaze()  # 複雜迷宮

# 劍士進入迷宮
sabar = hard_maze.adventur(sabar)
sabar = easy_maze.adventur(sabar)
print("sabar level:", sabar.level)

print("\n==========================\n")

# 劍士再次挑戰迷宮
sabar = hard_maze.adventur(sabar)
print("sabar level:", sabar.level)

print("\n==========================\n")

# 正義鋼彈進入迷宮
justice = hard_maze.adventur(justice)
print("justice level:", justice.level)

