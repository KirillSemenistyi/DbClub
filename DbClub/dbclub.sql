-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Апр 20 2024 г., 15:25
-- Версия сервера: 10.4.32-MariaDB
-- Версия PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `dbclub`
--

-- --------------------------------------------------------

--
-- Структура таблицы `computers`
--

CREATE TABLE `computers` (
  `id` int(11) NOT NULL,
  `computer_name` varchar(50) NOT NULL,
  `specifications` varchar(200) DEFAULT NULL,
  `status` enum('available','occupied','maintenance') NOT NULL DEFAULT 'available'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `computers`
--

INSERT INTO `computers` (`id`, `computer_name`, `specifications`, `status`) VALUES
(1, 'PC-1', 'Intel Core i5, 8GB RAM, 500GB HDD', 'available'),
(2, 'PC-2', 'Intel Core i7, 16GB RAM, 1TB SSD', 'occupied'),
(3, 'PC-3', 'AMD Ryzen 5, 16GB RAM, 500GB SSD', 'available'),
(4, 'PC-4', 'Intel Core i5, 12GB RAM, 500GB SSD', 'maintenance'),
(5, 'PC-5', 'AMD Ryzen 7, 32GB RAM, 2TB SSD', 'available');

-- --------------------------------------------------------

--
-- Структура таблицы `services`
--

CREATE TABLE `services` (
  `id` int(11) NOT NULL,
  `service_name` varchar(100) NOT NULL,
  `price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `services`
--

INSERT INTO `services` (`id`, `service_name`, `price`) VALUES
(1, 'Печать документов', 100.00),
(2, 'Сканирование', 150.00),
(3, 'Ксерокопирование', 80.00),
(4, 'Доступ в интернет (1 час)', 500.00),
(5, 'Игровая сессия (1 час)', 1000.00);

-- --------------------------------------------------------

--
-- Структура таблицы `service_orders`
--

CREATE TABLE `service_orders` (
  `id` int(11) NOT NULL,
  `visit_id` int(11) NOT NULL,
  `service_id` int(11) NOT NULL,
  `count` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `service_orders`
--

INSERT INTO `service_orders` (`id`, `visit_id`, `service_id`, `count`) VALUES
(1, 1, 1, 2),
(2, 1, 4, 1),
(3, 2, 2, 1),
(4, 2, 5, 1),
(5, 3, 3, 3),
(6, 4, 4, 2),
(7, 5, 1, 1),
(8, 5, 4, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `IdUser` int(11) NOT NULL,
  `Login` varchar(20) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Role` enum('Администратор','Кадровик','Пользователь') NOT NULL,
  `IsLock` tinyint(1) NOT NULL DEFAULT 0,
  `DateLock` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`IdUser`, `Login`, `Password`, `Role`, `IsLock`, `DateLock`) VALUES
(5, 'admin', 'admin', 'Администратор', 0, NULL),
(8, 'user', 'user', 'Пользователь', 0, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `visitors`
--

CREATE TABLE `visitors` (
  `id` int(11) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone` varchar(11) DEFAULT NULL,
  `registration_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `visitors`
--

INSERT INTO `visitors` (`id`, `surname`, `first_name`, `last_name`, `email`, `phone`, `registration_date`) VALUES
(1, 'Ксенонов', 'Иван', 'Иванов', 'ivan.ivanov@example.com', '79285738621', '2024-02-05'),
(2, 'Ранько', 'Петр', 'Петров', 'petr.petrov@example.com', '79186925626', '2023-02-15'),
(3, 'Шевченко', 'Анна', 'Сидорова', 'anna.sidorova@example.com', '79980176921', '2019-12-25'),
(4, 'Гальненко', 'Ольга', 'Кузнецова', 'olga.kuznetsova@example.com', '79961807625', '2023-04-05'),
(5, 'Доминин', 'Сергей', 'Андреевич', 'sergey.smirnov@example.com', '79816275692', '2020-12-09');

-- --------------------------------------------------------

--
-- Структура таблицы `visits`
--

CREATE TABLE `visits` (
  `id` int(11) NOT NULL,
  `visitor_id` int(11) NOT NULL,
  `computer_id` int(11) NOT NULL,
  `start_time` datetime NOT NULL,
  `end_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `visits`
--

INSERT INTO `visits` (`id`, `visitor_id`, `computer_id`, `start_time`, `end_time`) VALUES
(1, 1, 1, '2023-06-01 10:00:00', '2023-06-01 12:30:00'),
(2, 2, 2, '2023-06-01 13:00:00', '2023-06-01 15:00:00'),
(3, 3, 3, '2023-06-02 09:30:00', '2023-06-02 11:00:00'),
(4, 4, 5, '2023-06-02 14:00:00', '2023-06-02 16:30:00'),
(5, 5, 1, '2023-06-03 11:00:00', '2023-06-03 13:00:00');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `computers`
--
ALTER TABLE `computers`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `service_orders`
--
ALTER TABLE `service_orders`
  ADD PRIMARY KEY (`id`),
  ADD KEY `visit_id` (`visit_id`),
  ADD KEY `service_id` (`service_id`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`IdUser`),
  ADD UNIQUE KEY `Login` (`Login`);

--
-- Индексы таблицы `visitors`
--
ALTER TABLE `visitors`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `uniq` (`email`,`phone`) USING BTREE;

--
-- Индексы таблицы `visits`
--
ALTER TABLE `visits`
  ADD PRIMARY KEY (`id`),
  ADD KEY `visitor_id` (`visitor_id`),
  ADD KEY `computer_id` (`computer_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `computers`
--
ALTER TABLE `computers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `services`
--
ALTER TABLE `services`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `service_orders`
--
ALTER TABLE `service_orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `IdUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `visitors`
--
ALTER TABLE `visitors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `visits`
--
ALTER TABLE `visits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `service_orders`
--
ALTER TABLE `service_orders`
  ADD CONSTRAINT `service_orders_ibfk_1` FOREIGN KEY (`visit_id`) REFERENCES `visits` (`id`),
  ADD CONSTRAINT `service_orders_ibfk_2` FOREIGN KEY (`service_id`) REFERENCES `services` (`id`);

--
-- Ограничения внешнего ключа таблицы `visits`
--
ALTER TABLE `visits`
  ADD CONSTRAINT `visits_ibfk_1` FOREIGN KEY (`visitor_id`) REFERENCES `visitors` (`id`),
  ADD CONSTRAINT `visits_ibfk_2` FOREIGN KEY (`computer_id`) REFERENCES `computers` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
