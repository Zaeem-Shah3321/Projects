import sys
import time
import pandas as pd
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtWidgets import QTableWidgetItem

def is_numeric(value):
    try:
        float(value)
        return True
    except ValueError:
        return False

def bubble_sort(data, column_index):
    n = len(data)
    for i in range(n):
        for j in range(0, n - i - 1):
            if is_numeric(data[j][column_index]) and is_numeric(data[j + 1][column_index]):
                if float(data[j][column_index]) > float(data[j + 1][column_index]):
                    data[j], data[j + 1] = data[j + 1], data[j]
            else:
                if str(data[j][column_index]) > str(data[j + 1][column_index]):
                    data[j], data[j + 1] = data[j + 1], data[j]
    return data

def insertion_sort(data, column_index):
    for i in range(1, len(data)):
        key = data[i]
        j = i - 1
        while j >= 0:
            if is_numeric(key[column_index]) and is_numeric(data[j][column_index]):
                if float(key[column_index]) < float(data[j][column_index]):
                    data[j + 1] = data[j]
                else:
                    break
            else:
                if str(key[column_index]) < str(data[j][column_index]):
                    data[j + 1] = data[j]
                else:
                    break
            j -= 1
        data[j + 1] = key
    return data

def selection_sort(data, column_index):
    for i in range(len(data)):
        min_idx = i
        for j in range(i + 1, len(data)):
            if is_numeric(data[j][column_index]) and is_numeric(data[min_idx][column_index]):
                if float(data[j][column_index]) < float(data[min_idx][column_index]):
                    min_idx = j
            else:
                if str(data[j][column_index]) < str(data[min_idx][column_index]):
                    min_idx = j
        data[i], data[min_idx] = data[min_idx], data[i]
    return data

def merge_sort(data, column_index):
    if len(data) > 1:
        mid = len(data) // 2
        L = data[:mid]
        R = data[mid:]

        merge_sort(L, column_index)
        merge_sort(R, column_index)

        i = j = k = 0

        while i < len(L) and j < len(R):
            if is_numeric(L[i][column_index]) and is_numeric(R[j][column_index]):
                if float(L[i][column_index]) < float(R[j][column_index]):
                    data[k] = L[i]
                    i += 1
                else:
                    data[k] = R[j]
                    j += 1
            else:
                if str(L[i][column_index]) < str(R[j][column_index]):
                    data[k] = L[i]
                    i += 1
                else:
                    data[k] = R[j]
                    j += 1
            k += 1

        while i < len(L):
            data[k] = L[i]
            i += 1
            k += 1

        while j < len(R):
            data[k] = R[j]
            j += 1
            k += 1

    return data

def quick_sort(data, column_index):
    if len(data) <= 1:
        return data
    pivot = data[len(data) // 2]
    
    if is_numeric(pivot[column_index]):
        left = [x for x in data if is_numeric(x[column_index]) and float(x[column_index]) < float(pivot[column_index])]
        middle = [x for x in data if is_numeric(x[column_index]) and float(x[column_index]) == float(pivot[column_index])]
        right = [x for x in data if is_numeric(x[column_index]) and float(x[column_index]) > float(pivot[column_index])]
    else:
        left = [x for x in data if str(x[column_index]) < str(pivot[column_index])]
        middle = [x for x in data if str(x[column_index]) == str(pivot[column_index])]
        right = [x for x in data if str(x[column_index]) > str(pivot[column_index])]
    
    return quick_sort(left, column_index) + middle + quick_sort(right, column_index)

def bucket_sort(data, column_index):
    if not data:
        return data

    numeric_data = [item[column_index] for item in data if is_numeric(item[column_index])]

    if not numeric_data:
        return data 

    min_value = min(float(num) for num in numeric_data)
    max_value = max(float(num) for num in numeric_data)
    bucket_count = len(data) // 2 if len(data) > 2 else 1
    bucket_range = (max_value - min_value) / bucket_count

    buckets = [[] for _ in range(bucket_count)]

    for item in data:
        num = item[column_index]
        if is_numeric(num):
            index = int((float(num) - min_value) / bucket_range)
            if index == bucket_count: 
                index -= 1
            buckets[index].append(item)

    sorted_data = []
    for bucket in buckets:
        sorted_data.extend(sorted(bucket, key=lambda x: float(x[column_index])))

    non_numeric_data = [item for item in data if not is_numeric(item[column_index])]
    
    return sorted_data + non_numeric_data

def counting_sort(data, column_index):
    numeric_data = [item[column_index] for item in data if is_numeric(item[column_index]) and isinstance(item[column_index], int)]

    if not numeric_data:
        return data 

    max_value = max(numeric_data)
    min_value = min(numeric_data)
    range_of_elements = max_value - min_value + 1
    count = [0] * range_of_elements
    output = [None] * len(data)

    for item in data:
        if is_numeric(item[column_index]) and isinstance(item[column_index], int):
            count[item[column_index] - min_value] += 1

    for i in range(1, len(count)):
        count[i] += count[i - 1]

    for item in reversed(data):
        if is_numeric(item[column_index]) and isinstance(item[column_index], int):
            output[count[item[column_index] - min_value] - 1] = item
            count[item[column_index] - min_value] -= 1

    non_integer_data = [item for item in data if not isinstance(item[column_index], int)]
    
    sorted_data = [x for x in output if x is not None] + non_integer_data

    return sorted_data

def radix_sort(data, column_index):
    def counting_sort_for_radix(data, exp):
        n = len(data)
        output = [None] * n
        count = [0] * 10

        for i in range(n):
            if isinstance(data[i][column_index], int):
                index = data[i][column_index] // exp
                count[index % 10] += 1

        for i in range(1, 10):
            count[i] += count[i - 1]

        for i in range(n - 1, -1, -1):
            if isinstance(data[i][column_index], int):
                index = data[i][column_index] // exp
                output[count[index % 10] - 1] = data[i]
                count[index % 10] -= 1

        for i in range(n):
            data[i] = output[i]

    if not data:
        return data

    numeric_data = [item[column_index] for item in data if isinstance(item[column_index], int)]

    if not numeric_data:
        return data

    max_value = max(numeric_data)
    exp = 1
    while max_value // exp > 0:
        counting_sort_for_radix(data, exp)
        exp *= 10

    return data

class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(800, 600)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.centralwidget.setStyleSheet("""
            background-color: #3CB371;  /* Parrot Green */
            font-family: Arial; 
            color: #ffffff;
        """)

        # Title
        self.titleLabel = QtWidgets.QLabel("SORTING ALGORITHMS", self.centralwidget)
        self.titleLabel.setGeometry(QtCore.QRect(200, 20, 700, 30))
        self.titleLabel.setStyleSheet("font-size: 28px; font-weight: bold; color: #ffffff;")
        
        
        # ComboBox for sorting algorithms
        self.comboBox_algorithm = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_algorithm.setGeometry(QtCore.QRect(50, 70, 200, 30))
        self.comboBox_algorithm.setStyleSheet("""
            padding: 8px; 
            background-color: #ffffff; 
            color: #333333; 
            border-radius: 5px;
        """)
        self.comboBox_algorithm.addItems([
            "Bubble Sort", 
            "Insertion Sort", 
            "Selection Sort", 
            "Merge Sort", 
            "Quick Sort", 
            "Radix Sort", 
            "Count Sort", 
            "Bucket Sort"
        ])

        self.comboBox_column = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_column.setGeometry(QtCore.QRect(270, 70, 200, 30))
        self.comboBox_column.setStyleSheet("""
            padding: 8px; 
            background-color: #ffffff; 
            color: #333333; 
            border-radius: 5px;
        """)

        self.pushButton_sort = QtWidgets.QPushButton("Sort", self.centralwidget)
        self.pushButton_sort.setGeometry(QtCore.QRect(490, 70, 100, 30))
        self.pushButton_sort.setStyleSheet("""
            background-color: #4CAF50; 
            color: white; 
            border: none; 
            border-radius: 5px; 
            font-weight: bold;
            padding: 5px;
        """)
        self.pushButton_sort.clicked.connect(self.sort_data)

        self.searchInput = QtWidgets.QLineEdit(self.centralwidget)
        self.searchInput.setGeometry(QtCore.QRect(50, 120, 200, 30))
        self.searchInput.setStyleSheet("""
            padding: 8px; 
            background-color: #ffffff; 
            color: #333333; 
            border-radius: 5px;
        """)
        self.searchInput.setPlaceholderText("Search...")

        self.pushButton_search = QtWidgets.QPushButton("Search", self.centralwidget)
        self.pushButton_search.setGeometry(QtCore.QRect(270, 120, 100, 30))
        self.pushButton_search.setStyleSheet("""
            background-color: #2196F3; 
            color: white; 
            border: none; 
            border-radius: 5px; 
            font-weight: bold;
            padding: 5px;
        """)
        self.pushButton_search.clicked.connect(self.perform_search)

        self.timer_label = QtWidgets.QLabel("Time: 0.00000000s", self.centralwidget)
        self.timer_label.setGeometry(QtCore.QRect(480, 120, 250, 30))  
        self.timer_label.setStyleSheet("color: white; font-size: 16px; font-weight: bold;") 
 
        self.tableWidget = QtWidgets.QTableWidget(self.centralwidget)
        self.tableWidget.setGeometry(QtCore.QRect(50, 170, 700, 400))
        self.tableWidget.setObjectName("tableWidget")
        self.tableWidget.setStyleSheet("""
            border: 1px solid #ccc; 
            font-size: 14px; 
            background-color: #ffffff;
        """)
        self.tableWidget.setColumnCount(0)
        self.tableWidget.setRowCount(0)

        self.tableWidget.horizontalHeader().setStyleSheet("QHeaderView::section { background-color: #4CAF50; color: white; font-weight: bold; }")
        self.tableWidget.verticalHeader().setStyleSheet("QHeaderView::section { background-color: #4CAF50; color: white; font-weight: bold; }")

        self.label_time = QtWidgets.QLabel(self.centralwidget)
        self.label_time.setGeometry(QtCore.QRect(50, 580, 700, 30))
        self.label_time.setStyleSheet("font-weight: bold; color: #000000;")

        MainWindow.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        self.load_csv()

    def retranslateUi(self, MainWindow):
        MainWindow.setWindowTitle("Sorting Algorithms")

    def load_csv(self):
        self.data = pd.read_csv("final.csv").values.tolist()
        column_names = pd.read_csv("final.csv").columns.tolist()

        if not self.data:
            return

        self.tableWidget.setColumnCount(len(column_names))
        self.tableWidget.setRowCount(len(self.data))
        self.tableWidget.setHorizontalHeaderLabels(column_names)

        for row_index, row_data in enumerate(self.data):
            for col_index, item in enumerate(row_data):
                item_widget = QTableWidgetItem(str(item))
                item_widget.setForeground(QtGui.QColor(0, 0, 0)) 
                self.tableWidget.setItem(row_index, col_index, item_widget)

        self.comboBox_column.clear()
        self.comboBox_column.addItems(column_names)

    def sort_data(self):
        algorithm = self.comboBox_algorithm.currentText()
        column_index = self.comboBox_column.currentIndex()

        if column_index < 0 or not self.data:
            return

        sorting_algorithms = {
            "Bubble Sort": bubble_sort,
            "Insertion Sort": insertion_sort,
            "Selection Sort": selection_sort,
            "Merge Sort": merge_sort,
            "Quick Sort": quick_sort,
            "Bucket Sort": bucket_sort,
            "Count Sort": counting_sort,
            "Radix Sort": radix_sort,
        }

        start_time = time.time()
        self.data = sorting_algorithms[algorithm](self.data, column_index)
        end_time = time.time()

        self.update_table()
        self.label_time.setText(f"Sorted with {algorithm} in {end_time - start_time:.8f} seconds.")
        
        self.timer_label.setText(f"Time: {end_time - start_time:.8f}s")

    def perform_search(self):
        search_text = self.searchInput.text().strip().lower()
        if search_text == "":
            self.update_table()
            return
        
        filtered_data = [row for row in self.data if any(search_text in str(item).lower() for item in row)]
        self.tableWidget.setRowCount(len(filtered_data))
        for row_index, row_data in enumerate(filtered_data):
            for col_index, item in enumerate(row_data):
                item_widget = QTableWidgetItem(str(item))
                item_widget.setForeground(QtGui.QColor(0, 0, 0))  
                self.tableWidget.setItem(row_index, col_index, item_widget)

    def update_table(self):
        self.tableWidget.setRowCount(len(self.data))
        for row_index, row_data in enumerate(self.data):
            for col_index, item in enumerate(row_data):
                item_widget = QTableWidgetItem(str(item))
                item_widget.setForeground(QtGui.QColor(0, 0, 0))  
                self.tableWidget.setItem(row_index, col_index, item_widget)

if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())