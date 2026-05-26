# TangLessonsNotes

这里用于记录唐老狮 Unity 教程中的知识点，并补充当前 Unity 版本下的理解和选择建议。

## 项目当前环境

- Unity 版本：`6000.3.10f1`
- Input System：`1.18.0`
- 教程来源：唐老狮 Unity 教程练习
- 教程时间背景：约 2022 年

## 初始记录：输入系统对照

### 教程写法是否仍然可用

如果教程中使用 `Input.GetAxis`、`Input.GetKey` 等旧输入系统 API，在当前 Unity 中仍然可以用于小型练习和概念学习，尤其适合快速理解键盘、鼠标输入和每帧检测。

### 当前 Unity 版本是否有更推荐的新做法

当前项目已经安装 `com.unity.inputsystem`，因此新项目或需要更清晰输入配置的项目，更推荐使用 Unity Input System，通过 `.inputactions` 文件配置 Action Map、Action 和 Binding。

### 旧写法和新写法的区别

- 旧输入系统：代码直观，上手快，适合早期学习；但输入配置分散在代码和 Project Settings 中，扩展手柄、重绑定和多设备时不够清晰。
- 新 Input System：配置更系统，适合多设备和可维护项目；但概念更多，需要理解 Action Map、Action、Binding、启用/禁用和回调订阅。

### 适合初学阶段的选择建议

初学阶段可以先理解旧输入系统的“每帧读取输入”模型，再逐步切换到新 Input System。学习重点不是立刻追求复杂封装，而是弄清楚输入值从哪里来、什么时候更新、脚本什么时候启用和禁用。
