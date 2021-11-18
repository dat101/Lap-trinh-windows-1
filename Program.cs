using System;
using System.Collections.Generic;

namespace Quan_li_nhan_su
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Nhanvien> DSDV = new List<Nhanvien>();
			List<Khachhang> DBDV = new List<Khachhang>();
			while (true)
			{
				Menu();
				Console.Write("lua chon: ");
				string KT = Console.ReadLine();
				switch (KT)
				{
					case "ae":
						ThemNhanvien(DSDV);
						break;

					case "ac":
					    Themkhachhang(DBDV);
						break;

					case "dae":
					    TTNV(DSDV);
						break;

					case "dac":
					    TTKH(DBDV);
						break;

					case "cs":
				    	TKKH(DBDV);
						break;
						
					default:
						Console.WriteLine("Nhap sai ! Vui long nhap lai");
						continue;
				}
			}

			static void ThemNhanvien(List<Nhanvien> DSDV)
			{
				Console.Write("Ho ten: ");
				string KI = Console.ReadLine();
				Console.Write("Ma so: ");
				string KO = Console.ReadLine();
				Console.Write("Gioi tinh: ");
				string KP = Console.ReadLine();
				Console.Write("Ngay sinh: ");
				string Kl = Console.ReadLine();
				Console.Write("Bang cap: ");
				string KM = Console.ReadLine();
				Nhanvien NV = new Nhanvien(KO, KI, KP, Kl, KM);
				DSDV.Add(NV);
			}

			static void Themkhachhang(List<Khachhang> DBDV)
			{
				Console.Write("Ho ten: ");
				string KI = Console.ReadLine();
				Console.Write("Ma so: ");
				string KO = Console.ReadLine();
				Console.Write("Gioi tinh: ");
				string KP = Console.ReadLine();
				Console.Write("Ngay sinh: ");
				string Kl = Console.ReadLine();
				Console.Write("Loai khach hang: ");
				string KM = Console.ReadLine();
				Khachhang NV = new Khachhang(KO, KI, KP, Kl, KM);
				DBDV.Add(NV);
			}

			static void TTNV(List<Nhanvien> DSDV)
			{
				for (int i = 0; i < DSDV.Count; i++)
				{
					DSDV[i].infor();

				}
			}

			static void TTKH(List<Khachhang> DBDV)
			{
				for (int i = 0; i < DBDV.Count; i++)
				{
					DBDV[i].infor();

				}
			}

			static void TKKH(List<Khachhang> DBDV)
			{
				int Khachhangmoi = 0;
				int Thanhvien = 0;
				int vip = 0;
				for (int i = 0; i < DBDV.Count; i++)
				{
					if (DBDV[i].LoaiKH == "khach hang moi")
					{
						Khachhangmoi += 1;
					}
					else if (DBDV[i].LoaiKH == "thanh vien")
					{
						Thanhvien += 1;
					}
					else if (DBDV[i].LoaiKH == "vip")
					{
						vip += 1;
					}

				}
				Console.WriteLine("------Khach hang------");
				Console.WriteLine(" So khach hang moi: {0}", Khachhangmoi);
				Console.WriteLine(" So thanh vien: {0}", Thanhvien);
				Console.WriteLine(" So thanh vien VIP: {0}", vip);
			}

			static void Menu()
			{
				Console.WriteLine("Them nhan vien: ae");
				Console.WriteLine("Them khach hang: ac ");
				Console.WriteLine("hien thi thong tin nhan vien: dae ");
				Console.WriteLine("hien thi thong tin khach hang: dac ");
				Console.WriteLine("thong ke khach hang: cs ");
			}
		}
	}
}
