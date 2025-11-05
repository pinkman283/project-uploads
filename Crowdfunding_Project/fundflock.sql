-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 23, 2025 at 01:45 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fundflock`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `ID` int(11) NOT NULL,
  `Name` varchar(15) NOT NULL,
  `Email` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`ID`, `Name`, `Email`) VALUES
(1, '', ''),
(2, 'Maisha', 'maisha@gmail.com'),
(3, 'Shihab', 'shihab@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `campaign`
--

CREATE TABLE `campaign` (
  `title` text NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `campaign`
--

INSERT INTO `campaign` (`title`, `description`) VALUES
('hgfh', 'gdh');

-- --------------------------------------------------------

--
-- Table structure for table `campaigns`
--

CREATE TABLE `campaigns` (
  `id` int(11) NOT NULL,
  `campaign_url` text NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `campaign_updates`
--

CREATE TABLE `campaign_updates` (
  `id` int(11) NOT NULL,
  `message` text NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE `comment` (
  `id` int(11) NOT NULL,
  `comment_text` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `comment`
--

INSERT INTO `comment` (`id`, `comment_text`, `created_at`) VALUES
(1, 'h', '2025-01-12 13:30:03'),
(2, 'sdv', '2025-01-12 13:30:05'),
(3, 'sdv', '2025-01-12 13:30:11'),
(4, 'sdv', '2025-01-13 16:39:35'),
(5, 'sdv', '2025-01-13 16:41:18'),
(6, 'sdv', '2025-01-13 16:41:53'),
(7, 'sdv', '2025-01-13 16:41:56'),
(8, 'sdv', '2025-01-13 16:42:06'),
(9, 'sdv', '2025-01-13 16:42:46'),
(10, 'sdv', '2025-01-14 16:02:45'),
(11, 'sdv', '2025-01-14 16:15:19'),
(12, 'sdv', '2025-01-14 16:16:37'),
(13, 'sdv11', '2025-01-14 19:02:11');

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `comment` text NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`id`, `name`, `email`, `comment`, `created_at`) VALUES
(1, 'kvgukbhuo', 'akmshafiq78@gmail.com', 'wf', '2025-01-19 11:26:57'),
(2, 'kvgukbhuo', 'akmshafiq78@gmail.com', 'qddqd', '2025-01-19 11:28:06'),
(3, 'kvgukbhuo', 'akmshafiq78@gmail.com', 'xz x', '2025-01-19 13:40:22');

-- --------------------------------------------------------

--
-- Table structure for table `donation`
--

CREATE TABLE `donation` (
  `Account_No` text NOT NULL,
  `Amount` int(255) NOT NULL,
  `Method` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `donation`
--

INSERT INTO `donation` (`Account_No`, `Amount`, `Method`) VALUES
('02', 1000, 'PAYPAL'),
('02', 1000, 'PAYPAL'),
('02', 1000, 'PAYPAL'),
('02', 678, 'BANK'),
('02', 1000, 'BANK'),
('02', 4000, 'BANK'),
('02', 66, 'CREDIT_CARD'),
('02', 66, 'CREDIT_CARD'),
('02', 66, 'BANK'),
('02', 9, 'BANK'),
('02', 90, 'BANK'),
('02', 898, 'CREDIT_CARD'),
('02', 99, 'BANK'),
('02', 700, 'CREDIT_CARD'),
('02', 909, 'BANK'),
('02', 66, 'BANK'),
('02', 66, 'PAYPAL'),
('02', 1000, 'CREDIT_CARD'),
('02', 34, 'BANK'),
('02', 80, 'BANK'),
('03', 1000, 'CREDIT_CARD'),
('03', 9000, 'CREDIT_CARD'),
('03', 900, 'BANK');

-- --------------------------------------------------------

--
-- Table structure for table `example_table`
--

CREATE TABLE `example_table` (
  `id` int(6) UNSIGNED NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `reg_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `Review` text NOT NULL,
  `Question` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `feedback`
--

INSERT INTO `feedback` (`Review`, `Question`) VALUES
('Good', 'faijhlka'),
('good', 'jj'),
('good', 'jhj'),
('good', 'hgh'),
('good', 'hgh'),
('awesome', 'bhuh'),
('awesome', 'bhuh'),
('awesome', 'bhuh'),
('bad', 'hgjgh'),
('bad', 'hgjgh'),
('good', 'dfdfd');

-- --------------------------------------------------------

--
-- Table structure for table `mydb2.users`
--

CREATE TABLE `mydb2.users` (
  `ID` int(11) NOT NULL,
  `campaign_url` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `Email` text NOT NULL,
  `Donation Amount` int(11) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `projects`
--

CREATE TABLE `projects` (
  `id` int(11) NOT NULL,
  `project_name` varchar(255) NOT NULL,
  `deadline` date NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `review`
--

CREATE TABLE `review` (
  `reviews` varchar(150) NOT NULL,
  `comment` varchar(150) NOT NULL,
  `review_text` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `review`
--

INSERT INTO `review` (`reviews`, `comment`, `review_text`) VALUES
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r'),
('', '', 'erge4r');

-- --------------------------------------------------------

--
-- Table structure for table `reviews`
--

CREATE TABLE `reviews` (
  `id` int(11) NOT NULL,
  `review` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reviews`
--

INSERT INTO `reviews` (`id`, `review`) VALUES
(1, '&lt;?php echo $review; ?&gt;'),
(2, 'jk.'),
(3, 'rt5u');

-- --------------------------------------------------------

--
-- Table structure for table `rewards`
--

CREATE TABLE `rewards` (
  `ID` int(20) NOT NULL,
  `Payment` int(255) NOT NULL,
  `Badge` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rewards`
--

INSERT INTO `rewards` (`ID`, `Payment`, `Badge`) VALUES
(2, 10000, '5 Star'),
(3, 5000, '3 Star');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `Account_No` text NOT NULL,
  `Password` text NOT NULL,
  `Name` text NOT NULL,
  `Donation` int(255) NOT NULL,
  `Badge` text NOT NULL,
  `Email` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`Account_No`, `Password`, `Name`, `Donation`, `Badge`, `Email`) VALUES
('acc-01', 'Sunzidul Shaon', '', 20000, 'Gold', ''),
('02', '123', 'Maiasha Sultana', 52936, 'Gold', ''),
('03', '123', 'Tanvir Ahmed Abir', 30900, 'Silver', 'tanvir@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `user_info`
--

CREATE TABLE `user_info` (
  `name` text NOT NULL,
  `email` text DEFAULT NULL,
  `password` text NOT NULL,
  `user_type` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_info`
--

INSERT INTO `user_info` (`name`, `email`, `password`, `user_type`) VALUES
('[shihab]', '[shovonshihab283@gmail.com]', '[123]', '[user]'),
('shovon', 'sanminna448@gmail.com', '123', 'admin'),
('shihab shovon', 'shihab1234@gmail.com', '123', 'user'),
('gfgf', 'ghdfd@gmail.com', '123', 'admin'),
('Maiasha Sultana', 'gfh@gmail.com', '123', 'user'),
('shihab', 's@gmail.com', '123', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `campaigns`
--
ALTER TABLE `campaigns`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `campaign_updates`
--
ALTER TABLE `campaign_updates`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `example_table`
--
ALTER TABLE `example_table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mydb2.users`
--
ALTER TABLE `mydb2.users`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `projects`
--
ALTER TABLE `projects`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `reviews`
--
ALTER TABLE `reviews`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user_info`
--
ALTER TABLE `user_info`
  ADD UNIQUE KEY `unique` (`email`) USING HASH;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `campaigns`
--
ALTER TABLE `campaigns`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `campaign_updates`
--
ALTER TABLE `campaign_updates`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `comment`
--
ALTER TABLE `comment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `example_table`
--
ALTER TABLE `example_table`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `projects`
--
ALTER TABLE `projects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `reviews`
--
ALTER TABLE `reviews`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
