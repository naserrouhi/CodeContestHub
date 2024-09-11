## Thinkful - Object Drills: Quarks

### Background
You're modelling the interaction between a large number of quarks and have decided to create a `Quark` class so you can generate your own quark objects.

Quarks are fundamental particles and the only fundamental particle to experience all four fundamental forces.

### Your task
Your Quark class should allow you to create quarks of any valid color (`"red"`, `"blue"`, and `"green"`) and any valid flavor (`'up'`, `'down'`, `'strange'`, `'charm'`, `'top'`, and `'bottom'`).

Every quark has the same `baryon_number` (`BaryonNumber` in `C#`): 1/3.

Every quark should have an `.interact()` (`.Interact()` in `C#`) method that allows any quark to interact with another quark via the strong force. When two quarks interact they exchange colors.

### Example

```csharp
>>> Quark q1 = new Quark("red", "up");
>>> q1.Color;
"red"
>>> Quark q2 = new Quark("blue", "strange");
>>> q2.Color;
"blue"
>>> q2.BaryonNumber;
0.3333333333333333
>>> q1.Interact(q2);
>>> q1.Color;
"blue"
>>> q2.Color;
"red"
```