# ⚔️ Hero vs Monster - Console Battle Game

A simple yet fun turn-based battle simulator written in **C#**. In this console game, a **Hero** and a **Monster** take turns attacking each other until one is defeated.

---

## 🕹️ How It Works

1. The player sets a name for the **Hero** and the **Monster**.
2. Both start with **10 health points**.
3. On each turn, a random attack value between **1 and 9** is generated.
4. The **Hero** and **Monster** take turns attacking each other.
5. The first to drop to **0 or below health** loses.
6. The winner is announced at the end.

---

## 🔁 Features

- ✅ Dynamic naming for both hero and monster
- ✅ Randomized attack damage (1–10)
- ✅ Turn-based combat system
- ✅ Input validation (hero and monster can't share the same name and there are default names (as Hero and Monster))
- ✅ Health points can be changed. (Default 10)
- ✅ Clear winner announcement

---

## 🎮 Sample Gameplay Default Settings

```
Your name:
Monster name:
Health points:

Monster was damaged and lost 8 health and now has 2 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 10 health and now has -8 health.
Hero wins!
```

---

## 🎮 Sample Gameplay Custom Settings

```
Your name: Huseyin
Monster name: Goblin
Health points: 35

Goblin was damaged and lost 10 health and now has 25 health.
Huseyin was damaged and lost 1 health and now has 34 health.
Goblin was damaged and lost 2 health and now has 23 health.
Huseyin was damaged and lost 5 health and now has 29 health.
Goblin was damaged and lost 2 health and now has 21 health.
Huseyin was damaged and lost 5 health and now has 24 health.
Goblin was damaged and lost 8 health and now has 13 health.
Huseyin was damaged and lost 6 health and now has 18 health.
Goblin was damaged and lost 8 health and now has 5 health.
Huseyin was damaged and lost 6 health and now has 12 health.
Goblin was damaged and lost 10 health and now has -5 health.
Huseyin wins!
```
