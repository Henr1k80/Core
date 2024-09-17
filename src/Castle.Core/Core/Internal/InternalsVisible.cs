// Copyright 2004-2021 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.Core.Internal
{
	public static class InternalsVisible
	{
		/// <summary>
		///   Constant to use when making assembly internals visible to Castle.Core 
		///   <c>[assembly: InternalsVisibleTo(CoreInternalsVisible.ToCastleCore)]</c>
		/// </summary>
		public const string ToCastleCore =
			"Castle.Core, PublicKey=002400000480000094000000060200000024000052534131000400000100010077F5E87030DADCCCE6902C6ADAB7A987BD69CB5819991531F560785EACFC89B6FCDDF6BB2A00743A7194E454C0273447FC6EEC36474BA8E5A3823147D214298E4F9A631B1AFEE1A51FFEAE4672D498F14B000E3D321453CDD8AC064DE7E1CF4D222B7E81F54D4FD46725370D702A05B48738CC29D09228F1AA722AE1A9CA02FB";

		/// <summary>
		///   Constant to use when making assembly internals visible to proxy types generated by DynamicProxy. Required when proxying internal types.
		///   <c>[assembly: InternalsVisibleTo(CoreInternalsVisible.ToDynamicProxyGenAssembly2)]</c>
		/// </summary>
		public const string ToDynamicProxyGenAssembly2 =
			"DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7";

		internal static readonly byte[] DynamicProxyGenAssembly2PublicKey =
		{
			0x00, 0x24, 0x00, 0x00, 0x04, 0x80, 0x00, 0x00, 0x94, 0x00, 0x00, 0x00, 0x06, 0x02, 0x00, 0x00,
			0x00, 0x24, 0x00, 0x00, 0x52, 0x53, 0x41, 0x31, 0x00, 0x04, 0x00, 0x00, 0x01, 0x00, 0x01, 0x00,
			0xc5, 0x47, 0xca, 0xc3, 0x7a, 0xbd, 0x99, 0xc8, 0xdb, 0x22, 0x5e, 0xf2, 0xf6, 0xc8, 0xa3, 0x60,
			0x2f, 0x3b, 0x36, 0x06, 0xcc, 0x98, 0x91, 0x60, 0x5d, 0x02, 0xba, 0xa5, 0x61, 0x04, 0xf4, 0xcf,
			0xc0, 0x73, 0x4a, 0xa3, 0x9b, 0x93, 0xbf, 0x78, 0x52, 0xf7, 0xd9, 0x26, 0x66, 0x54, 0x75, 0x3c,
			0xc2, 0x97, 0xe7, 0xd2, 0xed, 0xfe, 0x0b, 0xac, 0x1c, 0xdc, 0xf9, 0xf7, 0x17, 0x24, 0x15, 0x50,
			0xe0, 0xa7, 0xb1, 0x91, 0x19, 0x5b, 0x76, 0x67, 0xbb, 0x4f, 0x64, 0xbc, 0xb8, 0xe2, 0x12, 0x13,
			0x80, 0xfd, 0x1d, 0x9d, 0x46, 0xad, 0x2d, 0x92, 0xd2, 0xd1, 0x56, 0x05, 0x09, 0x39, 0x24, 0xcc,
			0xea, 0xf7, 0x4c, 0x48, 0x61, 0xef, 0xf6, 0x2a, 0xbf, 0x69, 0xb9, 0x29, 0x1e, 0xd0, 0xa3, 0x40,
			0xe1, 0x13, 0xbe, 0x11, 0xe6, 0xa7, 0xd3, 0x11, 0x3e, 0x92, 0x48, 0x4c, 0xf7, 0x04, 0x5c, 0xc7
		};
	}
}