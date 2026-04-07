1. Clone project về máy

Mỗi thành viên mở Git Bash và chạy:

git clone https://github.com/buinamtruong1684/QLQuanCafe.git

👉 Sau đó mở project bằng Visual Studio
👉 Mở file .sln

🚀 2. Tạo branch riêng

👉 Mỗi người PHẢI tạo branch riêng (không làm trên main)

git checkout -b ten-phan-cua-ban
📌 Ví dụ:
Thành viên	Branch
Người 1	danhmuc-menu
Người 2	ban-nhanvien
Người 3	order-thanhtoan
Người 4	baocao-dashboard
🚀 3. Làm chức năng của mình

👉 Mỗi người:

Tạo Windows Form riêng
Code phần được giao
Không sửa file của người khác
🚀 4. Lưu code (commit)
git add .
git commit -m "Mo ta chuc nang"
🚀 5. Đẩy code lên GitHub
git push -u origin ten-branch
🚀 6. Leader merge code

👉 Leader sẽ:

Kiểm tra code
Merge vào branch main
⚠️ QUY ĐỊNH QUAN TRỌNG

❌ KHÔNG:

Không push trực tiếp vào main
Không sửa code người khác
Không làm chung 1 form

✔ PHẢI:

Mỗi người 1 branch
Mỗi người 1 chức năng
Test trước khi push
