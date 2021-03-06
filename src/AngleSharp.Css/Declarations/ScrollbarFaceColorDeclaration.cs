namespace AngleSharp.Css.Declarations
{
    using AngleSharp.Css.Values;
    using System;
    using static ValueConverters;

    static class ScrollbarFaceColorDeclaration
    {
        public static String Name = PropertyNames.ScrollbarFaceColor;

        public static IValueConverter Converter = Or(ColorConverter, AssignInitial(Colors.GetColor("threedface")));

        public static PropertyFlags Flags = PropertyFlags.Inherited;
    }
}
