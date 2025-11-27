using Blazor.ECharts.Options.Enum;

namespace Blazor.ECharts.Options;

/// <summary>
/// 坐标轴名称的文字样式
/// </summary>
public class NameTextStyle
{
    /// <summary>
    /// 坐标轴名称的颜色
    /// </summary>
    public string Color { set; get; }

    /// <summary>
    /// 坐标轴名称文字字体的风格
    /// </summary>
    public FontStyle? FontStyle { set; get; }

    /// <summary>backgroundColor
    /// 坐标轴名称文字字体的粗细
    /// <para>使用  FontWeight 枚举或者数字，如100、200、300、400...</para>
    /// </summary>
    public object FontWeight { set; get; }

    /// <summary>
    /// 坐标轴名称文字的字体系列
    /// </summary>
    public string FontFamily { set; get; }

    /// <summary>
    /// 坐标轴名称文字的字体大小
    /// </summary>
    public double? FontSize { set; get; }

    /// <summary>
    /// 文字水平对齐方式，默认自动。
    /// </summary>
    public Align? Align { set; get; }

    /// <summary>
    /// 文字垂直对齐方式，默认自动。
    /// </summary>
    public VerticalAlign? VerticalAlign { set; get; }

    /// <summary>
    /// 行高。
    /// <para>rich 中如果没有设置 lineHeight，则会取父层级的 lineHeight</para>
    /// </summary>
    public double? LineHeight { set; get; }

    /// <summary>
    /// 文字块背景色。
    /// </summary>
    public object BackgroundColor { set; get; }

    /// <summary>
    /// 文字块边框颜色。
    /// </summary>
    public string BorderColor { set; get; }

    /// <summary>
    /// 文字块边框宽度。
    /// </summary>
    public double? BorderWidth { get; set; }

    /// <summary>
    /// 文字块边框描边类型。默认为实线，支持 'solid', 'dashed', 'dotted'。<br/>
    /// 自 v5.0.0 开始，也可以是 number 或者 number 数组，用以指定线条的 dash array，配合 borderDashOffset 可实现更灵活的虚线效果。
    /// </summary>
    public object BorderType { set; get; }

    /// <summary>
    /// 用于设置虚线的偏移量，可搭配 borderType 指定 dash array 实现灵活的虚线效果。
    /// </summary>
    public double? BorderDashOffset { set; get; }

    /// <summary>
    /// 文字块的圆角。
    /// </summary>
    public object BorderRadius { set; get; }

    /// <summary>
    /// 文字块的内边距。
    /// <para>点击<see href="https://echarts.apache.org/zh/option.html#xAxis.nameTextStyle.padding">此处</see>查看详细设置</para>
    /// </summary>
    public object Padding { set; get; }

    /// <summary>
    /// 文字块的背景阴影颜色。
    /// </summary>
    public string ShadowColor { set; get; }

    /// <summary>
    /// 文字块的背景阴影长度。
    /// </summary>
    public double? ShadowBlur { set; get; }

    /// <summary>
    /// 文字块的背景阴影 X 偏移。
    /// </summary>
    public double? ShadowOffsetX { set; get; }

    /// <summary>
    /// 文字块的背景阴影 Y 偏移。
    /// </summary>
    public double? ShadowOffsetY { set; get; }

    /// <summary>
    /// 文本显示宽度
    /// </summary>
    public double? Width { set; get; }

    /// <summary>
    /// 文本显示高度。
    /// </summary>
    public double? Height { set; get; }

    /// <summary>
    /// 文字本身的描边颜色。
    /// </summary>
    public string TextBorderColor { set; get; }

    /// <summary>
    /// 文字本身的描边类型。默认为实线，支持 'solid', 'dashed', 'dotted'。<br/>
    /// 自 v5.0.0 开始，也可以是 number 或者 number 数组，用以指定线条的 dash array，配合 borderDashOffset 可实现更灵活的虚线效果。
    /// </summary>
    public object TextBorderType { set; get; }

    /// <summary>
    /// 用于设置虚线的偏移量，可搭配 borderType 指定 dash array 实现灵活的虚线效果。
    /// </summary>
    public double? TextBorderDashOffset { set; get; }

    /// <summary>
    /// 文字本身的背景阴影颜色。
    /// </summary>
    public string TextShadowColor { set; get; }

    /// <summary>
    /// 文字本身的背景阴影长度。
    /// </summary>
    public double? TextShadowBlur { set; get; }

    /// <summary>
    /// 文字本身的背景阴影 X 偏移。
    /// </summary>
    public double? TextShadowOffsetX { set; get; }

    /// <summary>
    /// 文字本身的背景阴影 Y 偏移。
    /// </summary>
    public double? TextShadowOffsetY { set; get; }

    /// <summary>
    /// 文字超出宽度是否截断或者换行。配置width时有效
    /// <para>'truncate' 截断，并在末尾显示ellipsis配置的文本，默认为...</para>
    /// <para>'break' 换行</para>
    /// <para>'breakAll' 换行，跟'break'不同的是，在英语等拉丁文中，'breakAll'还会强制单词内换行</para>
    /// </summary>
    public TextOverflow? Overflow { set; get; }

    /// <summary>
    /// 在 overflow 配置为'truncate'的时候，可以通过该属性配置末尾显示的文本。
    /// </summary>
    public string Ellipsis { set; get; }

    /// <summary>
    /// 在 rich 里面，可以自定义富文本样式。利用富文本样式，可以在标签中做出非常丰富的效果。
    /// <para>点击<see href="https://echarts.apache.org/zh/option.html#xAxis.nameTextStyle.rich">此处</see>查看详细设置</para>
    /// </summary>
    public object Rich { set; get; }

    /// <summary>
    /// 富文本样式是否继承普通文本样式。
    /// </summary>
    public bool? RichInheritPlainLabel { get; set; }
}