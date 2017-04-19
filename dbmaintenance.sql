-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 18, 2017 at 04:26 AM
-- Server version: 5.6.25
-- PHP Version: 5.6.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbmaintenance`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE IF NOT EXISTS `category` (
  `description` varchar(30) NOT NULL,
  `tipe` enum('HARDWARE','SOFTWARE') NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`description`, `tipe`, `status`) VALUES
('AD', 'HARDWARE', 0),
('HARDDISK', 'HARDWARE', 1),
('MOTHERBOARD', 'SOFTWARE', 1);

-- --------------------------------------------------------

--
-- Table structure for table `computers`
--

CREATE TABLE IF NOT EXISTS `computers` (
  `computername` varchar(50) NOT NULL,
  `location` varchar(50) NOT NULL,
  `user` varchar(50) NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `computers`
--

INSERT INTO `computers` (`computername`, `location`, `user`, `status`) VALUES
('ACC-001', 'OFFICE', 'HIKMAH', 1),
('ENW-001', 'ENGINEERING WORKSHOP', 'BOTAK', 1);

-- --------------------------------------------------------

--
-- Table structure for table `installation`
--

CREATE TABLE IF NOT EXISTS `installation` (
  `installid` int(11) NOT NULL,
  `computername` varchar(50) NOT NULL,
  `itemid` char(10) NOT NULL,
  `serialno` varchar(50) NOT NULL,
  `installdate` date NOT NULL,
  `uninistalldate` date DEFAULT NULL,
  `username` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `itemid` char(10) NOT NULL,
  `category` varchar(30) NOT NULL,
  `description` varchar(50) NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`itemid`, `category`, `description`, `status`) VALUES
('H-0001', 'HARDDISK', 'SEAGATE 120 GB', 1);

-- --------------------------------------------------------

--
-- Table structure for table `maintenance`
--

CREATE TABLE IF NOT EXISTS `maintenance` (
  `id` int(11) NOT NULL,
  `computername` varchar(50) NOT NULL,
  `maintenancedate` date NOT NULL,
  `motherboard` tinyint(1) NOT NULL,
  `processor` tinyint(1) NOT NULL,
  `hdd` tinyint(1) NOT NULL,
  `discdrive` tinyint(1) NOT NULL,
  `vga` tinyint(1) NOT NULL,
  `powersupply` tinyint(1) NOT NULL,
  `casing` tinyint(1) NOT NULL,
  `keyboard` tinyint(1) NOT NULL,
  `mouse` tinyint(1) NOT NULL,
  `lancard` tinyint(1) NOT NULL,
  `os` tinyint(1) NOT NULL,
  `av` tinyint(1) NOT NULL,
  `avlastupdate` tinyint(1) NOT NULL,
  `notes` tinyint(1) NOT NULL,
  `username` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `trouble`
--

CREATE TABLE IF NOT EXISTS `trouble` (
  `id` int(11) NOT NULL,
  `description` varchar(50) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `trouble`
--

INSERT INTO `trouble` (`id`, `description`) VALUES
(1, 'PC ERROR'),
(2, 'JARINGAN');

-- --------------------------------------------------------

--
-- Table structure for table `troubles`
--

CREATE TABLE IF NOT EXISTS `troubles` (
  `computername` varchar(50) NOT NULL,
  `troubleid` int(11) NOT NULL,
  `complainby` varchar(50) NOT NULL,
  `complaindate` date NOT NULL,
  `completeddate` date NOT NULL,
  `description` text NOT NULL,
  `solution` text NOT NULL,
  `username` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(50) NOT NULL,
  `password` char(32) NOT NULL,
  `fullname` varchar(50) NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `fullname`, `status`) VALUES
('admin', '21232f297a57a5a743894a0e4a801fc3', 'ADMINISTRATOR', 0),
('hafid', '829b36babd21be519fa5f9353daf5dbd', 'PROGRAMMER', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`description`);

--
-- Indexes for table `computers`
--
ALTER TABLE `computers`
  ADD PRIMARY KEY (`computername`);

--
-- Indexes for table `installation`
--
ALTER TABLE `installation`
  ADD PRIMARY KEY (`installid`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`itemid`);

--
-- Indexes for table `maintenance`
--
ALTER TABLE `maintenance`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `trouble`
--
ALTER TABLE `trouble`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `troubles`
--
ALTER TABLE `troubles`
  ADD PRIMARY KEY (`computername`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `installation`
--
ALTER TABLE `installation`
  MODIFY `installid` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `maintenance`
--
ALTER TABLE `maintenance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `trouble`
--
ALTER TABLE `trouble`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
