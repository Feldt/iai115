static void Main(string[] args)
        {
        //mostrar la dirección MAC 
        // Formato :  AABBCCDDEEFF
            Console.WriteLine(Program.GetMacAddress());
            Console.ReadKey();
        }

        /// <summary>
        /// Obtiene la dirección MAC de la PC en la que es ejecutado
        /// </summary>
        /// <returns></returns>
        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Sólo funciona con cable de Ethernet
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") 
                    && !nic.Description.Contains("Pseudo")))
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }
