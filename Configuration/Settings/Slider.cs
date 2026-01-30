using System;
using Spectre.Console;

namespace BeautifulConsole.GUI;

public enum SliderValueTypes { Integer, Boolean }

public class Slider
{
    public SliderValueTypes Type { get; }
    public bool Enabled { get; set; }
    public string Name { get; }
    private dynamic _Value;
    public dynamic Value
    {
        get => _Value;
        set
        {
            if (value is int i)
            {
                if (Type != SliderValueTypes.Integer)
                    throw new InvalidOperationException("Cannot set integer value to non-integer slider type");
                if (i < MinValue || i > MaxValue)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Value must be between {MinValue} and {MaxValue}");
                _Value = i;
            }
            else if (value is bool b)
            {
                if (Type != SliderValueTypes.Boolean)
                    throw new InvalidOperationException("Cannot set boolean value to non-boolean slider type");
                _Value = b;
            }
            else throw new ArgumentException("Unsupported value type for slider", nameof(value));
        }
    }
    public dynamic DefaultValue { get; }
    public int MinValue { get; }
    public int MaxValue { get; }
    public bool Looped = false;
    public bool HideValue = false;

    public Slider(string name, SliderValueTypes type = SliderValueTypes.Integer, dynamic initialValue = null, int minValue = 0, int maxValue = 1)
    {
        Enabled = true;
        Name = name;
        Type = type;
        switch (type)
        {
            case SliderValueTypes.Integer:
                MinValue = minValue;
                MaxValue = maxValue;
                _Value = initialValue is int i ? i : 0;
                DefaultValue = _Value;
                break;
            case SliderValueTypes.Boolean:
                MinValue = 0;
                MaxValue = 1;
                _Value = initialValue is bool b && b;
                DefaultValue = _Value;
                break;
        }
    }

    public void Draw(bool isSelected, int width)
    {
        string leftPadding = "  ";
        string colorPrefix = isSelected ? "[white on #1E3A8A]" : Enabled ? "[lime]" : "[#696969]";
        if (isSelected) leftPadding = "> ";
        string valueText = HideValue ? "" : $": [dim]{GetValue()}[/]";
        int minTextWidth = Name.Length + valueText.Length + 5;
        int availableWidth = width - leftPadding.Length - minTextWidth - 5;
        int barWidth = Math.Min(MaxValue - MinValue + 1, Math.Max(0, availableWidth));
        string bar = new string('═', barWidth);
        int pointerPosition = 0;
        if (Type == SliderValueTypes.Integer)
        {
            double position = (_Value - MinValue) * (barWidth - 1) / (double)(MaxValue - MinValue);
            pointerPosition = (int)Math.Round(position);
        }
        else if (Type == SliderValueTypes.Boolean) pointerPosition = (bool)_Value ? barWidth - 1 : 0;
        pointerPosition = Math.Max(0, Math.Min(pointerPosition, barWidth - 1));
        bar = bar.Remove(pointerPosition, 1).Insert(pointerPosition, "█");
        string text = $"{Name}{valueText}";
        string barText = $"|{bar}|";
        int paddingsLength = 2;
        paddingsLength += leftPadding.Length;
        string line = leftPadding + text + barText.PadLeft(width - (text.Length + paddingsLength));
        AnsiConsole.MarkupLine($"{colorPrefix}{line}[/]");
    }

    public void ToDefault() => _Value = DefaultValue;

    private string GetValue()
    {
        switch (Type)
        {
            case SliderValueTypes.Integer: return _Value.ToString();
            case SliderValueTypes.Boolean: return _Value ? "On" : "Off";
            default: return _Value.ToString();
        }
    }

    public void Increase(int value = 1)
    {
        if (!Enabled) return;
        switch (Type)
        {
            case SliderValueTypes.Integer:
                int newIntValue = _Value + value;
                if (Looped)
                {
                    int range = MaxValue - MinValue + 1;
                    newIntValue = MinValue + ((newIntValue - MinValue) % range);
                    if (newIntValue < MinValue) newIntValue += range;
                }
                else newIntValue = Math.Min(MaxValue, newIntValue);
                _Value = newIntValue;
                break;
            case SliderValueTypes.Boolean:
                if (Looped) _Value = !(bool)_Value;
                else _Value = true;
                break;
        }
    }

    public void Decrease(int value = 1)
    {
        if (!Enabled) return;
        switch (Type)
        {
            case SliderValueTypes.Integer:
                int newIntValue = _Value - value;
                if (Looped)
                {
                    int range = MaxValue - MinValue + 1;
                    newIntValue = MinValue + ((newIntValue - MinValue) % range);
                    if (newIntValue < MinValue) newIntValue += range;
                }
                else newIntValue = Math.Max(MinValue, newIntValue);
                _Value = newIntValue;
                break;
            case SliderValueTypes.Boolean:
                if (Looped) _Value = !(bool)_Value;
                else _Value = false;
                break;
        }
    }

    public void Enable() => Enabled = true;

    public void Disable() => Enabled = false;
}
