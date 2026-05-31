# 阶段暂停 - 转学 UGUI 与 PlayerPrefs

## 背景

唐老狮教程后续进入补充知识点，并准备开始制作入门教程项目。在正式继续该项目之前，教程路线提到需要学习 GUI 和 PlayerPrefs。

## 当前判断

`OnGUI` 属于 Unity 较早期的即时模式 GUI，当前实际项目中已经比较少作为主力 UI 方案使用。

因此，本项目暂时搁置一段时间，先学习 UGUI 和 PlayerPrefs。学完后再回来继续完成唐老狮入门教程项目，并优先使用 UGUI 制作项目界面。

## 学习安排

- `OnGUI`：了解历史用途和教程写法，能看懂即可。
- `UGUI`：重点学习，后续项目主力使用。
- `PlayerPrefs`：重点学习，用于保存轻量本地数据。

## UGUI 重点

- Canvas
- RectTransform
- Button
- Text / TMP
- Image
- Panel
- UI 事件绑定
- 菜单、设置面板、游戏界面和结算界面组织

## PlayerPrefs 重点

- 保存和读取音量设置。
- 保存最高分。
- 保存简单选项。
- 保存轻量关卡或进度状态。
- 理解 `SetInt`、`SetFloat`、`SetString`、`GetInt`、`GetFloat`、`GetString`、`Save`。

## 回到本项目后的计划

- 使用 UGUI 制作项目菜单。
- 使用 UGUI 制作设置界面。
- 使用 PlayerPrefs 保存音量和简单设置。
- 将前面学过的输入、物理、音频等知识整合到入门项目中。
- 避免使用 `OnGUI` 作为正式界面方案，除非只是做临时调试。

## 当前状态

项目暂停，不代表放弃。当前目标是先补齐 UI 和本地存储能力，再回来继续完成入门项目。
