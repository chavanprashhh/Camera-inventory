-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 18, 2023 at 10:40 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `camera_inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `camera_sale`
--

CREATE TABLE `camera_sale` (
  `ID` int(11) NOT NULL,
  `Status` varchar(255) NOT NULL,
  `Sold to` varchar(255) NOT NULL,
  `Phone No` varchar(255) NOT NULL,
  `Inventory ID` int(50) NOT NULL,
  `Staff ID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `camera_sale`
--

INSERT INTO `camera_sale` (`ID`, `Status`, `Sold to`, `Phone No`, `Inventory ID`, `Staff ID`) VALUES
(1, 'Sold ', 'deads', '1213', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `ID` int(50) NOT NULL,
  `Item` varchar(100) NOT NULL,
  `Quantity` varchar(100) NOT NULL,
  `Supplier ID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`ID`, `Item`, `Quantity`, `Supplier ID`) VALUES
(1, 'asde', '131', 1),
(2, 'sda', '2134', 2);

-- --------------------------------------------------------

--
-- Table structure for table `repair_request`
--

CREATE TABLE `repair_request` (
  `ID` int(11) NOT NULL,
  `Phone no` varchar(100) NOT NULL,
  `Customer Name` varchar(255) NOT NULL,
  `Problem` varchar(255) NOT NULL,
  `Order Type` varchar(255) NOT NULL,
  `Staff ID` int(11) NOT NULL,
  `Delivery Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `repair_request`
--

INSERT INTO `repair_request` (`ID`, `Phone no`, `Customer Name`, `Problem`, `Order Type`, `Staff ID`, `Delivery Date`) VALUES
(1, '891u2893213', 'erling homelander', 'DSLR', 'Normal', 1, '2023-04-18');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `Staff_ID` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Phone` varchar(255) NOT NULL,
  `Specialization` varchar(255) NOT NULL,
  `stno` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`Staff_ID`, `username`, `password`, `Name`, `Address`, `Phone`, `Specialization`, `stno`) VALUES
(1, 'admin', 'admin', 'kiran', 'thanel', '12213123', 'DSLR', '2121'),
(2, 'pra', 'pra', 'prayashh', 'thanel', '123121', 'Lens ', '21312');

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Phone No` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`ID`, `Name`, `Address`, `Phone No`) VALUES
(1, 'Baburao apte', '9823123412321', 'Thamel'),
(2, 'Erling haaland', '4213495', 'Manchester, england '),
(5, 'agueroo', 'sadedea', '21213');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attend`
--

CREATE TABLE `tbl_attend` (
  `ID` int(11) NOT NULL,
  `stno` varchar(100) NOT NULL,
  `attendate` varchar(100) NOT NULL,
  `intime` varchar(100) NOT NULL,
  `instatus` varchar(100) NOT NULL,
  `outitme` varchar(100) NOT NULL,
  `outstatus` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_attend`
--

INSERT INTO `tbl_attend` (`ID`, `stno`, `attendate`, `intime`, `instatus`, `outitme`, `outstatus`) VALUES
(1, '2121', '23-04-18', '09:37:32 AM', 'Time out', '10:33:12 AM', 'Time out'),
(2, '21312', '23-04-18', '10:10:41 AM', 'Time in', '', ''),
(3, '2121', '23-04-18', '10:11:24 AM', 'Time in', '10:33:12 AM', 'Time out'),
(4, '2121', '23-04-18', '10:11:56 AM', 'Time in', '10:33:12 AM', 'Time out');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `camera_sale`
--
ALTER TABLE `camera_sale`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `invid` (`Inventory ID`),
  ADD KEY `stid` (`Staff ID`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `supplieridfk` (`Supplier ID`);

--
-- Indexes for table `repair_request`
--
ALTER TABLE `repair_request`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Staff ID` (`Staff ID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`Staff_ID`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_attend`
--
ALTER TABLE `tbl_attend`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `camera_sale`
--
ALTER TABLE `camera_sale`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `repair_request`
--
ALTER TABLE `repair_request`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `Staff_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_attend`
--
ALTER TABLE `tbl_attend`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `camera_sale`
--
ALTER TABLE `camera_sale`
  ADD CONSTRAINT `invid` FOREIGN KEY (`Inventory ID`) REFERENCES `inventory` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stid` FOREIGN KEY (`Staff ID`) REFERENCES `staff` (`Staff_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `supplieridfk` FOREIGN KEY (`Supplier ID`) REFERENCES `suppliers` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `repair_request`
--
ALTER TABLE `repair_request`
  ADD CONSTRAINT `repair_request_ibfk_1` FOREIGN KEY (`Staff ID`) REFERENCES `staff` (`Staff_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
