-- phpMyAdmin SQL Dump
-- version 4.6.6deb5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Май 30 2020 г., 23:03
-- Версия сервера: 5.7.30-0ubuntu0.18.04.1
-- Версия PHP: 7.2.24-0ubuntu0.18.04.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `sklad`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Accounts`
--

CREATE TABLE `Accounts` (
  `ID` varchar(10) NOT NULL,
  `FIO` varchar(30) NOT NULL COMMENT 'ФИО Работника',
  `EmployeesPosition` varchar(20) NOT NULL COMMENT 'Должность',
  `Права` varchar(10) NOT NULL COMMENT 'Права доступа'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `Invoices`
--

CREATE TABLE `Invoices` (
  `Number` int(11) NOT NULL,
  `ID` varchar(10) NOT NULL,
  `TechniqueType` varchar(20) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `CreateDate` date NOT NULL,
  `AcceptInvoiceFio` varchar(50) NOT NULL,
  `Passed the invoice` varchar(50) NOT NULL,
  `Type` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `manufacturer_storehouses`
--

CREATE TABLE `manufacturer_storehouses` (
  `ID` varchar(10) NOT NULL,
  `Number` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `ProductInfo`
--

CREATE TABLE `ProductInfo` (
  `InvoiceId` varchar(10) NOT NULL COMMENT 'Айди накладной, к которой принадлежит запись',
  `Name` varchar(50) NOT NULL,
  `Cost` int(11) NOT NULL,
  `Count` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `storehouse_place`
--

CREATE TABLE `storehouse_place` (
  `ID` varchar(10) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Text` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `technique`
--

CREATE TABLE `technique` (
  `ID` varchar(10) NOT NULL,
  `Type` varchar(10) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Count` int(11) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `technique_types`
--

CREATE TABLE `technique_types` (
  `ID` varchar(10) NOT NULL,
  `Name` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Invoices`
--
ALTER TABLE `Invoices`
  ADD PRIMARY KEY (`Number`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Invoices`
--
ALTER TABLE `Invoices`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
