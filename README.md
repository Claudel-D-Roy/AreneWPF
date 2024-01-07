# Arena Game

Arena game in WPF, created during my final project in the second semester of my software development course.

## Arena Battles

You must form a team of two people and inform your instructor via MIO. In LÉA, there will be an Excel file containing the DevOPS - GIT link of your team that you must use for GIT transactions. In this assignment, you need to create a class library, a WPF project, and manage the documentation. The purpose of this application is to simulate medieval battles between several characters (minimum 8). Here is the simplified class hierarchy of characters that can be found in the arena:

First, you need to code these classes in a class library. Only the last classes are concrete; the others are abstract. The following characteristics must be well situated in these classes:
- Name, Level, Experience, Armor Class, Hit Points, Attack Bonus, Maximum Damage, Spells and potions (wizards only), Name of their demon (dark wizard only), Number of arrows (???),
- Victories, Defeats, Number of attacks,
- `Attack()`, other methods you deem necessary.
- Other constants, fields, properties, or methods that you find relevant.

Create an `Arena` class in the class library, containing the code necessary for the following functions:
- Creating a group of 8 different characters (or more if you wish, in an even number), whose type (Knight, Archer, Wizard (white or black)) is randomly determined. Initially, all characters have level 1 and experience 0.
- The first two characters fight: the first attacks and the second defends, then vice versa, until the first character is knocked out (Hit Points <= 0). Afterward, the next 2 characters fight. A character gains experience only in victory: Opponent's Level X 50 points. 0 points for a defeat.
- The battles rage until, at the end of a round, one of the characters reaches level 10. Each round, the order of characters must be randomly changed, and hit points reset to their initial value.
- An attack: Roll a d20; if the obtained number + attack bonus is greater than the opponent's armor class, they are hit; otherwise, the attack misses. Damage is calculated based on the attacker's damage die. Subtract the obtained number from the opponent's hit points.

Level increase (all characters):
| Character      | Warrior | Knight | Archer | Wizard (White) | Wizard (Black) |
| -------------- | ------- | ------ | ------ | -------------- | -------------- |
| Experience     | Level   | Experience | Level | Experience     | Level          |
| 0              | 1       | 14,000 | 6     | -              | -              |
| 300            | 2       | 23,000 | 7     | -              | -              |
| 900            | 3       | 34,000 | 8     | -              | -              |
| 2,700          | 4       | 48,000 | 9     | -              | -              |
| 6,500          | 5       | 64,000 | 10    | -              | -              |

Base values table per class:
| Characteristic | Knight | Archer | Wizard (White) | Wizard (Black) |
| --- | --- | --- | --- | --- |
| Starting Level | 1 | 1 | 1 | 1 |
| Starting Experience | 0 | 0 | 0 | 0 |
| Armor Class | 11 | 9 | 8 | 10 |
| Starting Hit Points | 20 | 17 | 9 | 11 |
| Maximum Damage | 1d8 | 1d8 | 1d10 | 2d4 |

Bonus values table to add to the d20 roll for attackers:
| Attacker | Wizards (White) | Wizards (Black) | Warriors | Knight | Archer | Wizards (White) |
| --- | --- | --- | --- | --- | --- | --- |
| Defender | White | Black | Knight | Archer | Wizards (Black) |
| White | 0 | +1 | +2 | +2 | +2 |
| Black | +1 | 0 | +2 | +2 | +2 |
| Warriors | +1 | +2 | 0 | +3 | - |
| Knight | +1 | +2 | +2 | 0 | - |
| Archer | +1 | +2 | +2 | 0 | - |

Visual interface(s) in the WPF project:
- Regarding the display in the visual interface, you must use your creativity. Use timers (timer or thread) to manage timing and displays.
- The main form should minimally contain:
  - A list (ListView) containing the 8 (minimum) fighters. Sort players by level and points in descending order by default.
  - Display statistics as battles progress.
  - Two possible execution modes (a Fight button and a checkbox named All):
    - If All is not checked and I click on Fight, statistics are displayed after the round (1 round = only the 8 fighters have fought until a defeat or victory). If I click again, the fights of the second round take place, and the statistics are refreshed at the end of this round. This continues until someone reaches level 10.
    - If All is checked, and I click on Fight, all rounds are executed until a character reaches level 10. Subsequently, statistics are displayed.
  - Add a Save button that saves the statistics to a JSON file.
  - Add a Load button that retrieves statistics from the JSON file.
  - Add a Reset button that resets combat statistics to zero so that you can restart the battles from the beginning at any time.

Generate automated documentation with DefaultDocumentation:
- Only the class library will be documented.
- Document the members of the class library with XML comments seen in class.
- Add the component (presented in class) that extracts XML information to produce automatic Markdown documentation.
- Publish everything in the DevOps GIT of this project.
- Design the README.MD page for the project's home page.
